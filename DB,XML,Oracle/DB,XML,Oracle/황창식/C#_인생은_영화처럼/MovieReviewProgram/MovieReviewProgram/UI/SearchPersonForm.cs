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
using TMDbLib.Client;

namespace MovieReviewProgram.UI
{
    partial class SearchPersonForm : Form
    {
        List<int> ids = new List<int>();
        public SearchPersonForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            getPersonList();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void getPersonList()
        {
            personSearchList.Items.Clear();
            ids.Clear();

            List<PersonInfo> persons = MovieApi.searchPerson(personInput.Text);
            foreach (PersonInfo person in persons)
            {
                personSearchList.Items.Add(new ListViewItem(new String[] { person.Name }));
                ids.Add(person.Id);
            }
        }

        private void personSearchList_Click(object sender, EventArgs e)
        {
            if (personSearchList.SelectedItems.Count != 0)
            {
                int n = personSearchList.SelectedItems[0].Index;
                int id = ids[n];
                getPersonImage(id);
            }
            else
            {

            }
        }

        public void getPersonImage(int id)
        {
            try
            {
                // 포스터 불러오기
                Bitmap DownloadImage = MovieApi.getPersonImage(id);
                personImage.Image = DownloadImage;
                personImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                // 이미지가 존재하지 않을때
                //MessageBox.Show("이미지가 없습니다.", "이미지 없음");
                personImage.Image = MovieApi.noImage();
                personImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void personInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                const char ENTER_KEY = (char)Keys.Enter;
                if (e.KeyChar == ENTER_KEY)
                    getPersonList();
            }
            catch (FormatException)
            {

            }
        }

        private void personDetail_Click(object sender, EventArgs e)
        {
            if (personSearchList.SelectedItems.Count != 0)
            {
                int n = personSearchList.SelectedItems[0].Index;
                int id = ids[n];
                new PersonDetailForm(id).ShowDialog();
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.", "선택한 항목 없음");
            }
        }
    }
}
