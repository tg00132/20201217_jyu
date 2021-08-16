using CarManager_0323.DB;
using CarManager_0323.Handler;
using CarManager_0323.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CarManager_0323.UI
{
    partial class DealViewForm : MaterialForm
    {
        private DaoOracle oracle;

        public DealViewForm()
        {
            InitializeComponent();
        }

        public DealViewForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        private void cusInfo_Click(object sender, EventArgs e)
        {
            if (dealList.SelectedItems.Count != 0)
            {
                int n = dealList.SelectedItems[0].Index;
                string cus_name = dealList.Items[n].SubItems[1].Text;
                new CustDetailViewForm(oracle, cus_name).Show();
            }
            dealList.Items.Clear();
            initDealView();
        }

        private void carInfo_Click(object sender, EventArgs e)
        {
            if (dealList.SelectedItems.Count != 0)
            {
                int n = dealList.SelectedItems[0].Index;
                string car_name = dealList.Items[n].SubItems[2].Text;
                string car_price = dealList.Items[n].SubItems[3].Text;
                new CarDetailViewForm(oracle, car_name, car_price).Show();
            }
            dealList.Items.Clear();
            initDealView();
        }

        private void sellerInfo_Click(object sender, EventArgs e)
        {
            if (dealList.SelectedItems.Count != 0)
            {
                int n = dealList.SelectedItems[0].Index;
                string s_name = dealList.Items[n].SubItems[4].Text;
                new SellerDetailViewForm(oracle, s_name).Show();
            }
            dealList.Items.Clear();
            initDealView();
        }

        public void initDealView()
        {
            List<ListModel> list = oracle.selectDeal();
            if (list.Count >= 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dealList.Items.Add(new ListViewItem(new string[]
                    { (i + 1).ToString(),
                    list[i].C_name,
                    list[i].Car_model,
                    list[i].Car_price,
                    list[i].S_name,
                    list[i].D_date
                    }));
                }

                setRowColor(dealList, Color.White, Color.Gainsboro);
                if (dealList.Items.Count > 0)
                {
                    int index = dealList.Items.Count - 1;
                    dealList.Items[index].Focused = true;
                    dealList.EnsureVisible(index);
                }
            }
            else
            {
                MessageBox.Show("정보가 없습니다.", "정보 없음");
                Close();
            }
        }

        public void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        private void DealViewForm_Load(object sender, EventArgs e)
        {
            initDealView();
        }

        private void viewClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            oracle.deleteAllDeal();
            oracle.deleteAllCar();
            oracle.deleteAllSeller();
            oracle.deleteAllCust();
            MessageBox.Show("데이터 전체 삭제 완료", "삭제 왼료");
            initDealView();
        }
    }
}
