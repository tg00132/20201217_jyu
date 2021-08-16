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
    partial class SellerDetailViewForm : MaterialForm
    {
        string sName;
        string sTel;
        int count;
        Seller seller;
        DaoOracle oracle;
        
        public SellerDetailViewForm(DaoOracle oracle, string sName)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.sName = sName;
        }

        private void SellerDetailViewForm_Load(object sender, EventArgs e)
        {
            count = oracle.sellerCount(sName);
            if(count == 1)
            {
                seller = oracle.selectSeller(sName);
            }
            else
            {
                sTel = new MessageBoxUtil().getInst().myInputBox("판매원의 전화번호를 입력하세요.", "이름 중복", "");
                seller = oracle.selectSeller(sName, sTel);
            }
            
            sellerName.Text = seller.Name;
            sellerTel.Text = seller.Tel;
            sellerEmail.Text = seller.Email;
            sellerGrade.Text = seller.Grade;
            sellerDeri.Text = seller.Derijum;
        }

        private void cusCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cusOK_Click(object sender, EventArgs e)
        {
            seller.Name = sellerName.Text;
            seller.Tel = sellerTel.Text;
            seller.Email = sellerEmail.Text;
            seller.Grade = sellerGrade.Text;
            seller.Derijum = sellerDeri.Text;
            if (count == 1)
            {
                oracle.updateSeller(seller, sName);
            }
            else
            {
                oracle.updateSeller(seller, sName, sTel);
            }
        }
    }
}
