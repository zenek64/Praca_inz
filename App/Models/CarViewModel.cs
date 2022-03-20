using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rok_Od { get; set; }
        public int Rok_Do { get; set; }
        public int Pojemnosc { get; set; }
        public int Moc { get; set; }
        public string Paliwo { get; set; }
        public int Drzwi { get; set; }
        public int Miejsca { get; set; }
        public int Bagaznik { get; set; }
        public string Nadwozie { get; set; }
        public decimal Przyspieszenie { get; set; }
        public int Vmax { get; set; }
        public string Skrzynia { get; set; }
        public int Biegi { get; set; }
        public string Naped { get; set; }
        public decimal Spalanie { get; set; }
        public int Cena { get; set; }
        public string Segment { get; set; }
        public int NCAP { get; set; }
    }
}