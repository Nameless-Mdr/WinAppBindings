namespace lab5Gum
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataViewCountry = new System.Windows.Forms.DataGridView();
            this.propertyCountry = new System.Windows.Forms.PropertyGrid();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.CreateFileBtn = new System.Windows.Forms.ToolStripButton();
            this.OpenFileBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveFileBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblErrorText = new System.Windows.Forms.ToolStripLabel();
            this.chartViewCountry = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureCountry = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ClearDataBtn = new System.Windows.Forms.Button();
            this.ClearPictureBtn = new System.Windows.Forms.Button();
            this.tbContinent = new System.Windows.Forms.TextBox();
            this.lblContinent = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.tbCapital = new System.Windows.Forms.TextBox();
            this.lblPopul = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.canselSelectBtn = new System.Windows.Forms.Button();
            this.numPopul = new System.Windows.Forms.NumericUpDown();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartViewCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewCountry
            // 
            this.dataViewCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCountry.Location = new System.Drawing.Point(0, 28);
            this.dataViewCountry.Name = "dataViewCountry";
            this.dataViewCountry.Size = new System.Drawing.Size(704, 363);
            this.dataViewCountry.TabIndex = 0;
            // 
            // propertyCountry
            // 
            this.propertyCountry.Location = new System.Drawing.Point(0, 397);
            this.propertyCountry.Name = "propertyCountry";
            this.propertyCountry.Size = new System.Drawing.Size(381, 352);
            this.propertyCountry.TabIndex = 1;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.toolStripSeparator, this.CreateFileBtn, this.OpenFileBtn, this.SaveFileBtn, this.toolStripSeparator1, this.lblErrorText });
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(1138, 25);
            this.bindingNavigator.TabIndex = 2;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // CreateFileBtn
            // 
            this.CreateFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateFileBtn.Image")));
            this.CreateFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateFileBtn.Name = "CreateFileBtn";
            this.CreateFileBtn.Size = new System.Drawing.Size(23, 22);
            this.CreateFileBtn.Text = "&Создать";
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileBtn.Image")));
            this.OpenFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(23, 22);
            this.OpenFileBtn.Text = "&Открыть";
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileBtn.Image")));
            this.SaveFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(23, 22);
            this.SaveFileBtn.Text = "&Сохранить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblErrorText
            // 
            this.lblErrorText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(86, 22);
            this.lblErrorText.Text = "toolStripLabel1";
            // 
            // chartViewCountry
            // 
            chartArea1.Name = "ChartArea1";
            this.chartViewCountry.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartViewCountry.Legends.Add(legend1);
            this.chartViewCountry.Location = new System.Drawing.Point(387, 397);
            this.chartViewCountry.Name = "chartViewCountry";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartViewCountry.Series.Add(series1);
            this.chartViewCountry.Size = new System.Drawing.Size(367, 352);
            this.chartViewCountry.TabIndex = 3;
            this.chartViewCountry.Text = "chart1";
            // 
            // pictureCountry
            // 
            this.pictureCountry.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCountry.Location = new System.Drawing.Point(710, 28);
            this.pictureCountry.Name = "pictureCountry";
            this.pictureCountry.Size = new System.Drawing.Size(410, 363);
            this.pictureCountry.TabIndex = 4;
            this.pictureCountry.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ClearDataBtn
            // 
            this.ClearDataBtn.Location = new System.Drawing.Point(760, 397);
            this.ClearDataBtn.Name = "ClearDataBtn";
            this.ClearDataBtn.Size = new System.Drawing.Size(178, 40);
            this.ClearDataBtn.TabIndex = 5;
            this.ClearDataBtn.Text = "Очистить данные";
            this.ClearDataBtn.UseVisualStyleBackColor = true;
            // 
            // ClearPictureBtn
            // 
            this.ClearPictureBtn.Location = new System.Drawing.Point(942, 397);
            this.ClearPictureBtn.Name = "ClearPictureBtn";
            this.ClearPictureBtn.Size = new System.Drawing.Size(178, 39);
            this.ClearPictureBtn.TabIndex = 6;
            this.ClearPictureBtn.Text = "Удалить изображение";
            this.ClearPictureBtn.UseVisualStyleBackColor = true;
            // 
            // tbContinent
            // 
            this.tbContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbContinent.Location = new System.Drawing.Point(942, 455);
            this.tbContinent.Name = "tbContinent";
            this.tbContinent.Size = new System.Drawing.Size(119, 26);
            this.tbContinent.TabIndex = 7;
            // 
            // lblContinent
            // 
            this.lblContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContinent.Location = new System.Drawing.Point(844, 455);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(92, 26);
            this.lblContinent.TabIndex = 13;
            this.lblContinent.Text = "Континент";
            // 
            // lblCountry
            // 
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.Location = new System.Drawing.Point(844, 487);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(92, 26);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Страна";
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCountry.Location = new System.Drawing.Point(942, 487);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(119, 26);
            this.tbCountry.TabIndex = 14;
            // 
            // lblCapital
            // 
            this.lblCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCapital.Location = new System.Drawing.Point(844, 519);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(92, 26);
            this.lblCapital.TabIndex = 17;
            this.lblCapital.Text = "Столица";
            // 
            // tbCapital
            // 
            this.tbCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCapital.Location = new System.Drawing.Point(942, 519);
            this.tbCapital.Name = "tbCapital";
            this.tbCapital.Size = new System.Drawing.Size(119, 26);
            this.tbCapital.TabIndex = 16;
            // 
            // lblPopul
            // 
            this.lblPopul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPopul.Location = new System.Drawing.Point(844, 551);
            this.lblPopul.Name = "lblPopul";
            this.lblPopul.Size = new System.Drawing.Size(92, 26);
            this.lblPopul.TabIndex = 19;
            this.lblPopul.Text = "Популяция";
            // 
            // lblSize
            // 
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSize.Location = new System.Drawing.Point(844, 583);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(92, 26);
            this.lblSize.TabIndex = 21;
            this.lblSize.Text = "Размер";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(822, 630);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(114, 39);
            this.selectBtn.TabIndex = 22;
            this.selectBtn.Text = "Поиск";
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // canselSelectBtn
            // 
            this.canselSelectBtn.Location = new System.Drawing.Point(942, 630);
            this.canselSelectBtn.Name = "canselSelectBtn";
            this.canselSelectBtn.Size = new System.Drawing.Size(114, 39);
            this.canselSelectBtn.TabIndex = 23;
            this.canselSelectBtn.Text = "Отмена";
            this.canselSelectBtn.UseVisualStyleBackColor = true;
            // 
            // numPopul
            // 
            this.numPopul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPopul.Location = new System.Drawing.Point(942, 551);
            this.numPopul.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.numPopul.Name = "numPopul";
            this.numPopul.Size = new System.Drawing.Size(119, 26);
            this.numPopul.TabIndex = 24;
            // 
            // numSize
            // 
            this.numSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSize.Location = new System.Drawing.Point(942, 583);
            this.numSize.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(119, 26);
            this.numSize.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 773);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.numPopul);
            this.Controls.Add(this.canselSelectBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPopul);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.tbCapital);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.lblContinent);
            this.Controls.Add(this.tbContinent);
            this.Controls.Add(this.ClearPictureBtn);
            this.Controls.Add(this.ClearDataBtn);
            this.Controls.Add(this.pictureCountry);
            this.Controls.Add(this.chartViewCountry);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.propertyCountry);
            this.Controls.Add(this.dataViewCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartViewCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown numSize;

        private System.Windows.Forms.NumericUpDown numPopul;

        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button canselSelectBtn;

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.TextBox tbCapital;
        private System.Windows.Forms.Label lblPopul;
        private System.Windows.Forms.Label lblSize;

        private System.Windows.Forms.Label lblContinent;

        private System.Windows.Forms.TextBox tbContinent;

        private System.Windows.Forms.ToolStripLabel lblErrorText;

        private System.Windows.Forms.Button ClearPictureBtn;

        private System.Windows.Forms.Button ClearDataBtn;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private System.Windows.Forms.ToolStripButton CreateFileBtn;
        private System.Windows.Forms.ToolStripButton OpenFileBtn;
        private System.Windows.Forms.ToolStripButton SaveFileBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;

        private System.Windows.Forms.PropertyGrid propertyCountry;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartViewCountry;
        private System.Windows.Forms.PictureBox pictureCountry;

        private System.Windows.Forms.DataGridView dataViewCountry;

        #endregion
    }
}