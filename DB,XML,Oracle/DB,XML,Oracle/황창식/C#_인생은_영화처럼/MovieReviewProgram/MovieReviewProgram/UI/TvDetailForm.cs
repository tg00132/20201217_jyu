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
using TMDbLib.Objects.General;
using TMDbLib.Objects.TvShows;

namespace MovieReviewProgram.UI
{

    partial class TvDetailForm : Form
    {
        int id;

        public TvDetailForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async void TvDetailForm_Load(object sender, EventArgs e)
        {
            TvShow tv = await MovieApi.getTvShowAsync(id);
            setImage();
            tvName.Text = tv.Name;
            setDirector(tv);
            List<Genre> genres = tv.Genres;
            genre.Text = Convert.ToString(genres[0].Name);
            string firstDate = MovieApi.getDate(tv.FirstAirDate.ToString());
            string lastDate = MovieApi.getDate(tv.LastAirDate.ToString());
            releaseDate.Text = string.Format("{0} ~ {1}", firstDate, lastDate);
            overView.Text = tv.Overview;
            overView.TextAlign = ContentAlignment.TopLeft;
            setCast(tv);
        }

        public void setDirector(TvShow tv)
        {
            try
            {
                string director = "";
                string writer = "";
                // 전체 스텝들 중 감독인 사람 이름 불러오기
                // 여러명이면 첫번쨰 감독만 불러오기
                foreach (Crew crew in tv.Credits.Crew)
                {
                    Console.WriteLine(string.Format("{0}, {1}"), crew.Name, crew.Job);
                    if (crew.Job == "Director")
                    {
                        director = crew.Name;
                        break;
                    }
                }
                // 여러명이면 첫번째 각본가만 불러오기
                foreach (Crew crew in tv.Credits.Crew)
                {
                    if (crew.Job == "Writer")
                    {
                        writer = crew.Name;
                        break;
                    }
                }
                tvDirector.Text = director;
                tvWriter.Text = writer;
            }
            catch (Exception)
            {
                tvDirector.Text = "Unknown";
                tvWriter.Text = "Unknown";
            }
        }

        public void setImage()
        {
            try
            {
                // 포스터 불러오기
                Bitmap DownloadImage = MovieApi.getTvImage(id);
                tvPoster.Image = DownloadImage;
                tvPoster.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                // 이미지가 존재하지 않을때
                //MessageBox.Show("이미지가 없습니다.", "이미지 없음");
                tvPoster.Image = MovieApi.noImage();
                tvPoster.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        public void setCast(TvShow tv)
        {
            List<Cast> casts = tv.Credits.Cast;
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
    }
}
