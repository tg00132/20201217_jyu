using CarManager_0323.DB;
using CarManager_0323.Handler;
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
    partial class AddDealForm : MaterialForm
    {
        DaoOracle dao;
        List<Deal> list;
        DealHandler dHandler;

        public AddDealForm()
        {
            InitializeComponent();
        }
        
        public AddDealForm(DaoOracle dao, List<Deal> list, DealHandler dHandler)
        {
            InitializeComponent();
            this.dao = dao;
            this.list = list;
            this.dHandler = dHandler;
        }

        private void dealOK_Click(object sender, EventArgs e)
        {
            insertCar();
            insertCustomer();
            insertSeller();
            dao.insertDeal(list[0].Seller, list[0].Customer, list[0].Car);
            dHandler.dealListClear();
            Console.WriteLine("데이터 추가 성공!!");
            MessageBox.Show("추가되었습니다", "추가 완료");
            Close();
        }

        public void insertCar()
        {
            if (carModel.Text == "" || carColor.Text == "" || carCompany.Text == "" || carPrice.Text == "" || carYear.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
            }

            else
            {
                try
                {
                    Car car = new Car(carModel.Text, carColor.Text, carCompany.Text, Int32.Parse(carPrice.Text), carYear.Text);
                    dao.insertCar(car);
                    list[0].Car = car;
                }
                catch (FormatException)
                {
                    MessageBox.Show("잘못된 숫자 입력방식 입니다.", "잘못된 입력방식");
                }
            }
        }

        public void insertCustomer()
        {
            if (cusName.Text == "" || cusTel.Text == "" || cusAddr.Text == "" || cusEmail.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
            }
            else
            {
                Customer customer = new Customer(cusName.Text, cusTel.Text, cusAddr.Text, cusEmail.Text);
                dao.insertCustomer(customer);
                list[0].Customer = customer;
            }
        }

        public void insertSeller()
        {
            if (sellerName.Text == "" || sellerTel.Text == "" || sellerEmail.Text == "" || sellerGrade.Text == "" || sellerDerijum.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
            }

            else
            {
                Seller seller = new Seller(sellerName.Text, sellerTel.Text, sellerEmail.Text, sellerGrade.Text, sellerDerijum.Text);
                dao.insertSeller(seller);
                list[0].Seller = seller;
            }
        }

        private void dealCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
