using MovieReviewProgram.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using TMDbLib.Objects.Movies;

namespace MovieReviewProgram.Common
{
    class DataManager
    {
        public static List<MovieInfo> movies = new List<MovieInfo>();

        // static이기때문에 DataManager 생성하자마자 메모리에 올라감
        static DataManager()
        {
            Load();
        }

        // xml파일에 있는 정보들을 List에 추가
        public static void Load()
        {
            movies.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Movies.xml");
                XElement carXElement = XElement.Parse(carsOutput);
                foreach (var item in carXElement.Descendants("movie"))
                {
                    string tempMovieTitle = item.Element("movieTitle").Value;
                    int tempMovieId = int.Parse(item.Element("movieId").Value);
                    string tempMovieGenre = item.Element("movieGenre").Value;
                    string tempMovieRDate = item.Element("movieRDate").Value;

                    MovieInfo tempMovie = new MovieInfo(tempMovieTitle, tempMovieId, tempMovieGenre, tempMovieRDate);
                    movies.Add(tempMovie);
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                CreateFile();
                Save();
                Load();
            }
        }

        // 파일 생성
        private static void CreateFile()
        {
            string fileName = @"./Movies.xml";
            StreamWriter writer = File.CreateText(fileName);
            writer.Dispose();
        }

        public static void Save()
        {
            string booksOutput = string.Empty;
            booksOutput += "<movies>\n";
            // 파일이 있을경우 List에 새로 추가한 데이터를 xml에 저장
            if (movies.Count > 0)
            {
                foreach (var item in movies)
                {
                    booksOutput += "<movie>\n";
                    booksOutput += $"   <movieTitle>{item.MovieTitle}</movieTitle>\n";
                    booksOutput += $"   <movieId>{item.MovieId}</movieId>\n";
                    booksOutput += $"   <movieGenre>{item.MovieGenre}</movieGenre>\n";
                    booksOutput += $"   <movieRDate>{item.MovieReleaseDate}</movieRDate>\n";
                    booksOutput += "</movie>\n";
                }

            }

            // List에 아무것도 없는 경우 임시 데이터 하나를 추가
            else
            {
                booksOutput += "<movie>\n";
                booksOutput += "   <movieTitle>타오르는 여인의 초상</movieTitle>\n";
                booksOutput += "   <movieId>531428</movieId>\n";
                booksOutput += "   <movieGenre>Drama</movieGenre>\n";
                booksOutput += "   <movieRDate>2019-06-17</movieRDate>\n";
                booksOutput += "</movie>\n";
            }
            booksOutput += "</movies>";
            File.WriteAllText(@"./Movies.xml", booksOutput);
        }

        // 로그파일 기록
        public static void printLog(string contents, string name = "favoriteMovies")
        {
            string directory = "favoriteMovies";
            DirectoryInfo di = new DirectoryInfo(directory);
            if (!di.Exists)
            {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter(directory + @"\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
