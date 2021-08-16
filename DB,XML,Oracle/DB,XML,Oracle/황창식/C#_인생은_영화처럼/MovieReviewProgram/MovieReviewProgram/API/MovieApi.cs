using MovieReviewProgram.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.People;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.TvShows;

namespace MovieReviewProgram.API
{
    class MovieApi
    {
        private static TMDbClient client = new TMDbClient("e1505e132578f77683ee1878346d1255");

        // 이름으로 영화 검색
        public static List<MovieInfo> searchMovies(string movieName)
        {
            List<MovieInfo> movies = new List<MovieInfo>();
            SearchContainer<SearchMovie> results = client.SearchMovieAsync(movieName).Result;
            Console.WriteLine($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results");
            System.Windows.Forms.MessageBox.Show($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results", "검색 완료");
            foreach (SearchMovie movie in results.Results)
            {
                movies.Add(new MovieInfo(movie.Id, movie.Title, movie.ReleaseDate.ToString()));
            }
            return movies;
        }

        // 이름으로 인물 검색
        public static List<PersonInfo> searchPerson(string castName)
        {
            List<PersonInfo> persons = new List<PersonInfo>();
            SearchContainer<SearchPerson> results = client.SearchPersonAsync(castName).Result;
            Console.WriteLine($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results");
            System.Windows.Forms.MessageBox.Show($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results", "검색 완료");
            foreach (SearchPerson person in results.Results)
            {
                persons.Add(new PersonInfo(person.Id, person.Name));
            }
            return persons;
        }

        // 인물 ID
        public static int searchPersonId(string name)
        {
            SearchContainer<SearchPerson> results = client.SearchPersonAsync(name).Result;
            return results.Results[0].Id;
        }

        // 제목으로 TV 시리즈 검색
        public static List<TVInfo> searchTV(string tvName)
        {
            List<TVInfo> tvs = new List<TVInfo>();
            SearchContainer<SearchTv> results = client.SearchTvShowAsync(tvName).Result;
            System.Windows.Forms.MessageBox.Show($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results", "검색 완료");
            foreach (SearchTv result in results.Results)
            {
                string country = "";
                for (int i = 0; i < result.OriginCountry.Count; i++)
                {
                    if (i == result.OriginCountry.Count - 1)
                        country += result.OriginCountry[i];
                    else
                        country += result.OriginCountry[i] + ", ";
                }
                tvs.Add(new TVInfo(result.Id, result.Name, country));
            }
            return tvs;
        }

        // 영화 포스터 불러오기
        public static Bitmap getMovieImage(int id)
        {
            Movie movie1 = client.GetMovieAsync(id).Result;
            WebClient Downloader = new WebClient();
            Stream ImageStream = Downloader.OpenRead("https://www.themoviedb.org/t/p/w600_and_h900_bestv2"
                + movie1.PosterPath);
            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            return DownloadImage;
        }
        
        // 인물 사진 불러오기
        public static Bitmap getPersonImage(int id)
        {
            Person person = client.GetPersonAsync(id).Result;
            WebClient Downloader = new WebClient();
            Stream ImageStream = Downloader.OpenRead("https://www.themoviedb.org/t/p/w600_and_h900_bestv2" + person.ProfilePath);
            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            return DownloadImage;
        }

        // TV 이미지 불러오기
        public static Bitmap getTvImage(int id)
        {
            TvShow tv = client.GetTvShowAsync(id).Result;
            WebClient Downloader = new WebClient();
            Stream ImageStream = Downloader.OpenRead("https://www.themoviedb.org/t/p/w600_and_h900_bestv2" + tv.PosterPath);
            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            return DownloadImage;
        }

        // 온라인 이미지가 없을 시
        public static Bitmap noImage()
        {
            WebClient Downloader = new WebClient();
            Stream ImageStream = Downloader.OpenRead("https://i.stack.imgur.com/y9DpT.jpg");
            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            return DownloadImage;
        }

        // 특정 영화 정보 불러오기
        public static async Task<Movie> getMovieAsync(int id)
        {
            return await client.GetMovieAsync(id, MovieMethods.Credits);
        }

        // 특정 인물 정보 불러오기
        public static async Task<Person> getPersonAsync(int id)
        {
            return await client.GetPersonAsync(id, PersonMethods.MovieCredits);
        }

        // 특정 TV시리즈 정보 불러오기
        public static async Task<TvShow> getTvShowAsync(int id)
        {
            return await client.GetTvShowAsync(id, TvShowMethods.Credits);
        }

        // 날자정보 자르기
        public static string getDate(string date)
        {
            try
            {
                string result = "";
                for (int i = 0; i < 10; i++)
                {
                    result += date[i];
                }
                return result;
            }
            catch (Exception)
            {
                return "None";
            }
            
        }
    }
}
