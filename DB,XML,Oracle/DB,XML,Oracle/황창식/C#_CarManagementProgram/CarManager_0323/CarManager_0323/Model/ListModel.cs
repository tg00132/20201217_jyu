using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_0323.Model
{
    class ListModel
    {
        private string c_name;
        private string car_model;
        private string car_price;
        private string s_name;
        private string d_date;

        public ListModel(string c_name, string car_model, string car_price, string name, string d_date)
        {
            this.c_name = c_name;
            this.car_model = car_model;
            this.car_price = car_price;
            s_name = name;
            this.d_date = d_date;
        }

        public string C_name { get => c_name; set => c_name = value; }
        public string Car_model { get => car_model; set => car_model = value; }
        public string Car_price { get => car_price; set => car_price = value; }
        public string S_name { get => s_name; set => s_name = value; }
        public string D_date { get => d_date; set => d_date = value; }
    }
}
