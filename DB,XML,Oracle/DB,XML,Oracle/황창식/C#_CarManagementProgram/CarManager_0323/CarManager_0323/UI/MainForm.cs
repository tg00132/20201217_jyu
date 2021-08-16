using CarManager_0323.DB;
using CarManager_0323.Model;
using CarManager_0323.UI;
using CarManager_0323.Handler;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager_0323
{
    public partial class MainForm : MaterialForm
    {
        DaoOracle dao = new DaoOracle();
        DealHandler dHandler = new DealHandler();

        public MainForm()
        {
            InitializeComponent();
        }

        private void createTable_Click(object sender, EventArgs e)
        {
            dao.makeTables();
        }

        private void deleteTable_Click(object sender, EventArgs e)
        {
            dao.dropTables();
        }

        /*private void insertData_Click(object sender, EventArgs e)
        {
            dao.insertDatas();
        }

        private void insertCar_Click(object sender, EventArgs e)
        {
            int checker = dao.tableChecker("CAR_T");
            if(checker >= 1)
            {
                List<Deal> list = dHandler.getOrderList();
                if (list[0].Car == null)
                {
                    new InstCarForm(dao, list).ShowDialog();
                }
                else
                {
                    MessageBox.Show("차량 정보가 이미 저장되었습니다.", "차량 추가 에러");
                }
            }
            else
            {
                MessageBox.Show("Car 테이블이 없습니다.", "실행 에러");
            }
            
        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            int checker = dao.tableChecker("CUSTOMER_T");
            if (checker >= 1)
            {
                List<Deal> list = dHandler.getOrderList();
                if (list[0].Customer == null)
                {
                    new InstCustomerForm(dao, list).ShowDialog();
                }
                else
                {
                    MessageBox.Show("고객 정보가 이미 저장되었습니다.", "고객 추가 에러");
                }
            }
            else
            {
                MessageBox.Show("Customer 테이블이 없습니다.", "실행 에러");
            }
        }

        private void insertSeller_Click(object sender, EventArgs e)
        {
            int checker = dao.tableChecker("SELLER_T");
            if (checker >= 1)
            {
                List<Deal> list = dHandler.getOrderList();
                if (list[0].Seller == null)
                {
                    new InstSellerForm(dao, list).ShowDialog();
                }
                else
                {
                    MessageBox.Show("판매자 정보가 이미 저장되었습니다.", "판매자 추가 에러");
                }
            }
            else
            {
                MessageBox.Show("Seller 테이블이 없습니다.", "실행 에러");
            }
            
        }*/

        private void insertOrder_Click(object sender, EventArgs e)
        {
            int checker = dao.tableChecker("DEAL_T");
            if (checker >= 1)
            {
                List<Deal> list = dHandler.getOrderList();
                new AddDealForm(dao, list, dHandler).ShowDialog();
            }
            else
            {
                MessageBox.Show("테이블이 없습니다.", "실행 에러");
            }
        }

        private void programExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectDeal_Click(object sender, EventArgs e)
        {
            new DealViewForm(dao).ShowDialog();
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Yorgos7784\n2021.03.31", "프로그램 정보");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int checker = dao.tableChecker("DEAL_T");
            if(checker == 0)
            {
                dao.makeTables();
            }
            else { }
        }
    }
}