using MovieReviewProgram.API;
using MovieReviewProgram.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewProgram.UI
{
    partial class SearchTVForm : Form
    {
        List<int> ids = new List<int>();

        public SearchTVForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            getTVList();
        }

        public void getTVList()
        {
            tvSearchList.Items.Clear();
            ids.Clear();

            List<TVInfo> tvs = MovieApi.searchTV(tvInput.Text);
            foreach (TVInfo tv in tvs)
            {
                // 불러온 목록 리스트에 추가
                tvSearchList.Items.Add(new ListViewItem(new String[] { tv.Name, tv.Country }));
                ids.Add(tv.Id);
            }
        }

        private void tvSearchList_Click(object sender, EventArgs e)
        {
            if (tvSearchList.SelectedItems.Count != 0)
            {
                int n = tvSearchList.SelectedItems[0].Index;
                int id = ids[n];
                getTvImage(id);
            }
            else
            {

            }
        }

        public void getTvImage(int id)
        {
            try
            {
                // 포스터 불러오기
                Bitmap DownloadImage = MovieApi.getTvImage(id);
                tvImage.Image = DownloadImage;
                tvImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                // 이미지가 존재하지 않을때
                //MessageBox.Show("이미지가 없습니다.", "이미지 없음");
                tvImage.Image = MovieApi.noImage();
                tvImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void tvInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                const char ENTER_KEY = (char)Keys.Enter;
                if (e.KeyChar == ENTER_KEY)
                    getTVList();
            }
            catch (FormatException)
            {

            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tvDetail_Click(object sender, EventArgs e)
        {
            if (tvSearchList.SelectedItems.Count != 0)
            {
                int n = tvSearchList.SelectedItems[0].Index;
                int id = ids[n];
                new TvDetailForm(id).ShowDialog();
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.", "선택한 항목 없음");
            }
        }
    }
}
