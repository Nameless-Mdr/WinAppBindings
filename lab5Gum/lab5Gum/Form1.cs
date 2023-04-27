using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using Common;
using Domain.Models;

namespace lab5Gum
{
    public partial class Form1 : Form
    {
        private List<Country> _countries = new List<Country>();
        private readonly BindingSource _source = new BindingSource();
        private string _currentPath = string.Empty;
        
        private const string RelativePathFiles = @"..\..\Data\";
        private const string RelativePathImages = @"..\..\CountryImages\";

        public Form1()
        {
            InitializeComponent();
            
            saveFileDialog.Filter = @"Save files(*.BIN;*.XML)|*.BIN;*.XML";
            var dirFiles = new DirectoryInfo(RelativePathFiles);
            saveFileDialog.InitialDirectory = dirFiles.FullName;

            _source.DataSource = _countries;

            bindingNavigator.BindingSource = _source;
            dataViewCountry.DataSource = _source;
            propertyCountry.DataBindings.Add("SelectedObject", _source, "");
            
            dataViewCountry.AllowUserToAddRows = false;
            dataViewCountry.ReadOnly = true;
            dataViewCountry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            pictureCountry.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // кнопки навигатор
            bindingNavigator.DeleteItem.Click += RefreshChart;
            lblErrorText.Text = string.Empty;
            
            CreateFileBtn.Click += CreateFile;
            OpenFileBtn.Click += OpenFile;
            OpenFileBtn.Click += RefreshChart;
            SaveFileBtn.Click += SaveFile;
            
            // кнопки формы
            ClearDataBtn.Click += ClearData;
            ClearPictureBtn.Click += RemoveImage;
            pictureCountry.MouseDoubleClick += AddImage;
            
            // события элементов интерфейса
            dataViewCountry.SelectionChanged += LoadImage;
            propertyCountry.PropertyValueChanged += RefreshChart;
            
            // кнопки для поиска
            selectBtn.Click += SelectItems;
            selectBtn.Click += RefreshChart;
            canselSelectBtn.Click += ResetItems;
            canselSelectBtn.Click += RefreshChart;
        }

        // метод фильтрации
        private void SelectItems(object sender, EventArgs e)
        {
            var continent = tbContinent.Text;
            var country = tbCountry.Text;
            var capital = tbCapital.Text;
            _source.DataSource = _countries
                .Where(x => (string.IsNullOrEmpty(continent) || x.Continent.ToString() == continent)
                            && (string.IsNullOrEmpty(country) || x.Name.Contains(country))
                            && (string.IsNullOrEmpty(capital) || x.Capital.Contains(capital))
                            && x.Population >= numPopul.Value && x.Size >= numSize.Value).ToList();
        }

        // метод очистки фильтрации
        private void ResetItems(object sender, EventArgs e)
        {
            tbContinent.Text = string.Empty;
            tbCountry.Text = string.Empty;
            tbCapital.Text = string.Empty;
            numPopul.Value = 0;
            numSize.Value = 0;
            _source.DataSource = _countries;
        }

        // метод обновления объекта chart
        private void RefreshChart(object sender, EventArgs e)
        {
            chartViewCountry.Series[0].ChartType = SeriesChartType.Pie;
            chartViewCountry.DataSource = ((List<Country>)_source.DataSource)
                .GroupBy(x => x.Continent.ToString())
                .Select(x => new { Name = x.Key, Count = x.Count() });
            chartViewCountry.Series[0].XValueMember = "Name";
            chartViewCountry.Series[0].YValueMembers = "Count";
        }
        
        // метод создания файла
        private void CreateFile(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _currentPath = saveFileDialog.FileName;
                var fileInfo = new FileInfo(_currentPath);
                if(fileInfo.Extension != ".xml" && fileInfo.Extension != ".bin")
                    return;
                using var fStream = new FileStream(_currentPath, FileMode.OpenOrCreate);
            }
        }
        
        // метод открытия файла
        private void OpenFile(object sender, EventArgs e)
        {
            lblErrorText.Text = string.Empty;
            var dirFiles = new DirectoryInfo(RelativePathFiles);
            openFileDialog.Filter = @"Open files(*.BIN;*.XML)|*.BIN;*.XML";
            openFileDialog.InitialDirectory = dirFiles.FullName;
            
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            _currentPath = openFileDialog.FileName;
            var fileInfo = new FileInfo(_currentPath);

            switch (fileInfo.Extension)
            {
                case ".bin":
                    FileStream fStream = null;
                    try
                    {
                        fStream = new FileStream(_currentPath, FileMode.Open);
                        var fmt = new BinaryFormatter();
                        _countries = (List<Country>)fmt.Deserialize(fStream);
                    }
                    catch
                    {
                        lblErrorText.Text = "Не удалось прочитать файл";
                    }
                    finally
                    {
                        fStream?.Close();
                    }
                    break;
                case ".xml":
                    var formatter = new XmlFormatter();
                    formatter.ErrorRead += (o, args) => lblErrorText.Text = "Не удалось прочитать файл";
                    _countries = formatter.FormatFile(_currentPath);
                    break;
            }
            _source.DataSource = _countries;
        }

        // метод сохранения файла
        private void SaveFile(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentPath) || !File.Exists(_currentPath)) return;
            var fileInfo = new FileInfo(_currentPath);
            switch (fileInfo.Extension)
            {
                case ".bin":
                    using (var fStream = new FileStream(_currentPath, FileMode.Open))
                    {
                        var fmt = new BinaryFormatter();
                        fmt.Serialize(fStream, _countries);
                    }
                    break;
                case ".xml":
                    using (var fStream = new FileStream(_currentPath, FileMode.Open))
                    {
                        var xmlSer = new XmlSerializer(typeof(List<Country>));
                        xmlSer.Serialize(fStream, _countries);
                    }
                    break;
            }
        }
        
        // метод добавления изображения в список
        private void AddImage(object sender, MouseEventArgs e)
        {
            if(dataViewCountry.Rows.Count == 0) return;
            var dirImages = new DirectoryInfo(RelativePathImages);
            openFileDialog.Filter = @"Image files(*.PNG;*.JPG;*.JPEG;*.GIF)|*.PNG;*.JPG;*.JPEG;*.GIF";
            openFileDialog.InitialDirectory = dirImages.FullName;
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            
            var path = openFileDialog.FileName;
            pictureCountry.Image = Image.FromFile(path);
            _countries[dataViewCountry.CurrentCell.RowIndex].ImagePath =
                path.Equals(dirImages.FullName + openFileDialog.SafeFileName)
                    ? RelativePathImages + openFileDialog.SafeFileName
                    : path;
        }

        // метод загрузки изображения на PictureBox
        private void LoadImage(object sender, EventArgs e)
        {
            if(dataViewCountry.Rows.Count == 0) return;
            var path = ((List<Country>)_source.DataSource)[dataViewCountry.CurrentCell.RowIndex].ImagePath ?? @"\";
            var dirImages = new FileInfo(path);
            pictureCountry.Image = !dirImages.Exists ? null : Image.FromFile(dirImages.FullName);
        }

        // метод удаления изображения
        private void RemoveImage(object sender, EventArgs e)
        {
            pictureCountry.Image = null;
            if (dataViewCountry.Rows.Count == 0) return;
            _countries[dataViewCountry.CurrentCell.RowIndex].ImagePath = @"\";
        }

        // метод очистки данных формы
        private void ClearData(object sender, EventArgs e)
        {
            pictureCountry.Image = null;
            chartViewCountry.Series[0].Points.Clear();
            dataViewCountry.Rows.Clear();
            _source.Clear();
            _countries.Clear();
            _currentPath = string.Empty;
            ResetItems(sender, e);

        }
    }
}