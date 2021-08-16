using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlappyBird_Windows_Form
{
    class data
    {
        public  static List<Ranking> rankings = new List<Ranking>();
        static data()
        {
            Load();
        }
        public static void Load()
        {
            rankings.Clear();
            try
            {

                String rankingOutput = File.ReadAllText(@"./ranking.xml");
                XElement rankXElement = XElement.Parse(rankingOutput);
                foreach (var item in rankXElement.Descendants("Rank"))
                {
                    if(!int.TryParse(item.Element("rank").Value, out int tempRank))
                    {
                        break;
                    }
                    int tempScore = int.Parse(item.Element("score").Value);
                    string tempName = item.Element("name").Value;


                    Ranking tempRanking = new Ranking()
                    {
                        Rank = tempRank,
                        Score = tempScore,
                        Name = tempName
                    };
                    rankings.Add(tempRanking);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                //만약 파일이 없어서 여기로 진입한 경우라면
                CreateFile();//파일을 새로 만들고
                Save();//그 파일을 저장한 다음
                Load();//다시 불러들여본다.
                //단, Load 함수 자체가 잘못된 거라면 이 코드는 무한루프에 빠진다.
            }


        }
        private static void CreateFile()
        {
            //Cars.xml 파일을 만들자.
            string fileName = @"./ranking.xml";
            StreamWriter writer = File.CreateText(fileName);// 파일이 없으면 해당 파일 생성
            writer.Dispose();//메모리 해제

        }
        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<Ranks>\n"; //\n 대신에 Enviroment.NewLine 써도됨.
            if (rankings.Count > 0)
            {
                foreach (var item in rankings)
                {
                    booksOutput += "<Rank>\n";
                    booksOutput += $"<rank>{item.Rank}</rank>\n ";
                    booksOutput += $"<score>{item.Score}</score>\n ";
                    booksOutput += $"<name>{item.Name}</name>\n ";
                    booksOutput += "</Rank>\n";
                }
            }
            else    // xml 파일에 아무 것도 없는 경우
            {
                for (int i = 0; i <= 1; i++)
                {
                    booksOutput += "<Rank>\n";
                    booksOutput += $"<rank></rank> \n";
                    booksOutput += $"<score></score>\n ";
                    booksOutput += $"<name></name> \n";
                    booksOutput += "</Rank>\n";
                }
            }
            booksOutput += "</Ranks>";
            File.WriteAllText(@"./ranking.xml", booksOutput);
        }
        public static void printLog(string contents, string name = "rank")
        {
            DirectoryInfo di = new DirectoryInfo("rank");
            if (!di.Exists)
            {
                di.Create(); // 폴더 만들기
            }
            //앞에 @ 있으면 \ 한개만
            // @ 없으면 \\ 이렇게 해야지 1개로 인식함
            //using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt", true))
            using (StreamWriter writer = new StreamWriter(@"rank\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
