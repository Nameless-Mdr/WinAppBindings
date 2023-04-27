using System;
using System.ComponentModel;
using Domain.Enums;

namespace Domain.Models
{
    [Serializable]
    public class Country
    {
        [DisplayName("Континент"), Category("Сводка")]
        public Continent Continent { get; set; }

        [DisplayName("Название"), Category("Сводка")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Население"), Category("Сводка")]
        public int Population { get; set; } = 0;

        [DisplayName("Столица"), Category("Сводка")]
        public string Capital { get; set; } = string.Empty;

        [DisplayName("Размер"), Category("Сводка")]
        public int Size { get; set; } = 0;

        [Browsable(false)] 
        public string ImagePath { get; set; } = @"\";
    }
}