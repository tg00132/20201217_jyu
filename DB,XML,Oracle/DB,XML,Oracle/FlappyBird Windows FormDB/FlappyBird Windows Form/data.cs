using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlappyBird_Windows_Form
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
                DBHelper.selectQuery();
                rankings.Clear();
                foreach (DataRow item in DBHelper.dt_rank.Rows)
                {
                    Ranking temp = new Ranking();
                    temp.Name = item["name"].ToString();
                    temp.Rank = int.Parse(item["ranks"].ToString());
                    temp.Score = int.Parse(item["score"].ToString());
                    rankings.Add(temp);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);
            }
        }

        public static void Save()
        {
            //table에 있는 걸 싹 다 지우고
            DBHelper.deleteQuery();
            foreach (var item in rankings) //list에 있는 것들을 다시 insert 쿼리 호출한다.
            {
                DBHelper.insertQuery(item.Rank, item.Score, item.Name);
            }
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

