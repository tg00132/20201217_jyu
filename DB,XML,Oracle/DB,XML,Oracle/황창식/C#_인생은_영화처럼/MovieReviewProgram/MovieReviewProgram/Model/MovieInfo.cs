using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReviewProgram.Model
{
    class MovieInfo
    {
        private int movieId;
        private string movieTitle;
        private string movieReleaseDate;
        private string movieGenre;
        public MovieInfo(int movieId, string movieTitle, string movieReleaseDate)
        {
            this.movieId = movieId;
            this.movieTitle = movieTitle;
            this.movieReleaseDate = movieReleaseDate;
        }
        
        public MovieInfo(string movieTitle, int movieId, string movieGenre,  string movieReleaseDate)
        {
            this.movieId = movieId;
            this.movieTitle = movieTitle;
            this.movieReleaseDate = movieReleaseDate;
            this.movieGenre = movieGenre;
        }

        public int MovieId { get => movieId; set => movieId = value; }
        public string MovieTitle { get => movieTitle; set => movieTitle = value; }
        public string MovieReleaseDate { get => movieReleaseDate; set => movieReleaseDate = value; }
        public string MovieGenre { get => movieGenre; set => movieGenre = value; }
    }
}
