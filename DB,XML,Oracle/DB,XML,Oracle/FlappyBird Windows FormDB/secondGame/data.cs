using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace secondGame
{
    class data
    {
        public static List<Ranking> rankings = new List<Ranking>();
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
                    if (!int.TryParse(item.Element("rank").Value, out int tempRank))
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

                
                CreateFile();
                Save();
                Load();
                
            }
        }
        private static void CreateFile()
        {
           
            string fileName = @"./ranking.xml";
            StreamWriter writer = File.CreateText(fileName);
            writer.Dispose();

        }
        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<Ranks>\n"; 
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
                di.Create(); 
            }
            using (StreamWriter writer = new StreamWriter(@"rank\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
