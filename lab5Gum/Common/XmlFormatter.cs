using System;
using System.Collections.Generic;
using System.Xml;
using Domain.Enums;
using Domain.Models;

namespace Common
{
    public class XmlFormatter
    {
        public event EventHandler ErrorRead;

        public List<Country> FormatFile(string path)
        {
            XmlDocument document;
            try
            {
                document = new XmlDocument();
                document.Load(path);
            }
            catch
            {
                ErrorRead?.Invoke(this, EventArgs.Empty);
                return new List<Country>();
            }

            var root = document.DocumentElement;
            var countries = new List<Country>();
            if (root == null) return new List<Country>();

            foreach (XmlElement country in root)
            {
                var temp = new Country();
                foreach (XmlNode attribute in country.ChildNodes)
                {
                    switch (attribute.Name)
                    {
                        case nameof(Country.Continent):
                            if (Enum.TryParse<Continent>(attribute.InnerText, out var continent))
                                temp.Continent = continent;
                            break;
                        case nameof(Country.Name):
                            temp.Name = attribute.InnerText;
                            break;
                        case nameof(Country.Population):
                            if (int.TryParse(attribute.InnerText, out var population))
                                temp.Population = population;
                            break;
                        case nameof(Country.Capital):
                            temp.Capital = attribute.InnerText;
                            break;
                        case nameof(Country.Size):
                            if (int.TryParse(attribute.InnerText, out var size))
                                temp.Size = size;
                            break;
                        case nameof(Country.ImagePath):
                            if (!string.IsNullOrEmpty(attribute.InnerText))
                                temp.ImagePath = attribute.InnerText;
                            break;
                    }
                }

                countries.Add(temp);
            }
            return countries;
        }
    }
}