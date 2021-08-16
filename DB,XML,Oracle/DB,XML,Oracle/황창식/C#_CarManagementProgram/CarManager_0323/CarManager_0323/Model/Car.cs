using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_0323.Model
{
    class Car
    {
        private string model;
        private string color;
        private string company;
        private int price;
        private string year;

        public Car(string model, string color, string company, int price, string year)
        {
            this.model = model;
            this.color = color;
            this.company = company;
            this.price = price;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string Company { get => company; set => company = value; }
        public int Price { get => price; set => price = value; }
        public string Year { get => year; set => year = value; }
    }
}
