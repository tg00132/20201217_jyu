using MovieReviewProgram.API;
using MovieReviewProgram.Common;
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
    partial class FavoriteForm : Form
    {
        List<int> ids = new List<int>();
        public FavoriteForm()
        {
            InitializeComponent();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FavoriteForm_Load(object sender, EventArgs e)
        {
            foreach (var movie in DataManager.movies)
            {
                favoriteMoiveList.Items.Add(new ListViewItem(new String[] { movie.MovieTitle, movie.MovieGenre, movie.MovieReleaseDate }));
                ids.Add(movie.MovieId);
            }
        }

        private void favoriteMoiveList_Click(object sender, EventArgs e)
        {
            if (favoriteMoiveList.SelectedItems.Count != 0)
            {
                int n = favoriteMoiveList.SelectedItems[0].Index;
                int id = ids[n];
                try
                {
                    // 포스터 불러오기
                    Bitmap DownloadImage = MovieApi.getMovieImage(id);
                    moviePoster.Image = DownloadImage;
                    moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception)
                {
                    // 이미지가 존재하지 않을때
                    //MessageBox.Show("이미지가 없습니다.", "이미지 없음");
                    moviePoster.Image = MovieApi.noImage();
                    moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {

            }
        }

        private void movieDetail_Click(object sender, EventArgs e)
        {
            if (favoriteMoiveList.SelectedItems.Count != 0)
            {
                int n = favoriteMoiveList.SelectedItems[0].Index;
                int id = ids[n];
                new MovieDetailForm(id).ShowDialog();
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.", "선택한 항목 없음");
            }
        }
    }
}
