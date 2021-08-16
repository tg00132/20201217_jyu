using CarManager_0323.DB;
using CarManager_0323.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager_0323.UI
{
    partial class CarDetailViewForm : MaterialForm
    {
        string car_name;
        string car_price;
        DaoOracle oracle;
        Car car;
        public CarDetailViewForm(DaoOracle oracle, string carName, string carPrice)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.car_name = carName;
            this.car_price = carPrice;
        }

        private void CarDetailViewForm_Load(object sender, EventArgs e)
        {
            car = oracle.selectCar(car_name, car_price);
            carModel.Text = car.Model;
            carColor.Text = car.Color;
            carComp.Text = car.Company;
            carPrice.Text = car.Price.ToString();
            carYear.Text = car.Year;
        }

        private void cusCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cusOK_Click(object sender, EventArgs e)
        {
            car.Model = carModel.Text;
            car.Color = carColor.Text;
            car.Company = carComp.Text;
            car.Price = int.Parse(carPrice.Text);
            car.Year = carYear.Text;
            oracle.updateCar(car, car_name, car_price);
            Close();
        }
    }
}
