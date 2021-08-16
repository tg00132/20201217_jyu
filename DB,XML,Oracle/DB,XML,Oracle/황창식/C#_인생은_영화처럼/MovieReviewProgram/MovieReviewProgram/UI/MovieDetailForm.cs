using MovieReviewProgram.API;
using MovieReviewProgram.Common;
using MovieReviewProgram.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;

namespace MovieReviewProgram.UI
{
    partial class MovieDetailForm : Form
    {
        int id;
        Movie movie1;
        public MovieDetailForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async void MovieDetailForm_Load(object sender, EventArgs e)
        {
            // 영화 전체 정보 불러오기
            movie1 = await MovieApi.getMovieAsync(id);

            // 영화 포스터
            setImage();

            // 영화 제목
            mName.Text = movie1.Title;

            // 영화 감독
            setDirector(movie1);

            // 영화 장르
            List<Genre> genres = movie1.Genres;
            genre.Text = genres[0].Name;

            // 영화 개봉일
            releaseDate.Text = MovieApi.getDate(movie1.ReleaseDate.ToString());

            // 줄거리
            overView.Text = movie1.Overview;
            overView.TextAlign = ContentAlignment.TopLeft;

            // 영화 출연진
            setCast(movie1);

        }

        public void setImage()
        {
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

        public void setDirector(Movie movie1)
        {
            try
            {
                string director = "";
                // 전체 스텝들 중 감독인 사람 이름 불러오기
                // 여러명이면 첫번쨰 감독만 불러오기
                foreach (Crew crew in movie1.Credits.Crew)
                {
                    if (crew.Job == "Director")
                    {
                        director = crew.Name;
                        break;
                    }
                }
                mDirector.Text = director;
            }
            catch (Exception)
            {
                mDirector.Text = "Unknown";
            }

        }

        public void setCast(Movie movie1)
        {
            List<Cast> casts = movie1.Credits.Cast;
            foreach (Cast cast in casts)
            {
                castList.Rows.Add(cast.Name, cast.Character);
            }

        }

        private void windowClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutAc_Click(object sender, EventArgs e)
        {
            try
            {
                string acName = castList.Rows[castList.SelectedRows[0].Index].Cells[0].Value.ToString();
                Console.WriteLine(acName);
                int id = MovieApi.searchPersonId(acName);
                new PersonDetailForm(id).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("선택된 항목이 없습니다.", "선택한 항목 없음");
            }
        }

        private void mDirector_Click(object sender, EventArgs e)
        {
            int id = MovieApi.searchPersonId(mDirector.Text);
            new PersonDetailForm(id).ShowDialog();
        }

        private void mDirector_MouseLeave(object sender, EventArgs e)
        {
            mDirector.ForeColor = Color.DodgerBlue;
            mDirector.Cursor = Cursors.Default;
        }

        private void mDirector_MouseEnter(object sender, EventArgs e)
        {
            mDirector.ForeColor = Color.LightSkyBlue;
            mDirector.Cursor = Cursors.Hand;
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in DataManager.movies)
            {
                if (movie1.Id == item.MovieId)
                {
                    MessageBox.Show("이미 추가되어 있습니다.", "추가 오류");
                    return;
                }
            }
            DataManager.movies.Add(new MovieInfo(movie1.Title, movie1.Id, movie1.Genres[0].Name, movie1.ReleaseDate.ToString()));
            MessageBox.Show("즐겨찾기에 추가되었습니다.", "추가 완료");
            DataManager.Save();
        }
    }
}
