using CarManager_0323.DB;
using CarManager_0323.Model;
using CarManager_0323.Util;
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
    partial class CustDetailViewForm : MaterialForm
    {
        string cus_name;
        string cus_tel;
        int count;
        DaoOracle oracle;

        public CustDetailViewForm()
        {
            InitializeComponent();
        }
        
        public CustDetailViewForm(DaoOracle oracle, string cus_name)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.cus_name = cus_name;
        }

        private void CustDetailViewForm_Load(object sender, EventArgs e)
        {
            count = oracle.cusCount(cus_name);
            if(count == 1)
            {
                Customer customer = oracle.selectCustomer(cus_name);
                cusName.Text = customer.Name;
                cusTel.Text = customer.Tel;
                cusAddr.Text = customer.Addr;
                cusEmail.Text = customer.Email;
            }

            else
            {
                cus_tel = new MessageBoxUtil().getInst().myInputBox("고객의 전화번호를 입력하세요.", "이름 중복", "");
                Customer customer = oracle.selectCustomer(cus_name, cus_tel);
                cusName.Text = customer.Name;
                cusTel.Text = customer.Tel;
                cusAddr.Text = customer.Addr;
                cusEmail.Text = customer.Email;
            }
        }

        private void cusCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cusOK_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(cusName.Text, cusTel.Text, cusAddr.Text, cusEmail.Text);
            if(count == 1)
            {
                oracle.updateCustomer(customer, cus_name);
                Close();
            }

            else
            {
                oracle.updateCustomer(customer, cus_name, cus_tel);
                Close();
            }
        }
    }
}
