using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondGame
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = data.rankings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //공간번호
            if (textBox1.Text.Trim() == "") //Trim 공백 제거 함수
            {
                MessageBox.Show("이름 입력해라");
                writeLog("이름 입력하라고");

            }
            else
            {
                try
                {
                    // 본격적으로 입력하는 작업
                    //Ranking ranking;
                    //참조변수 람다개념을 알고 있는 경우!

                    //무조건 한 명만 들어감
                    //ranking = data.rankings.Single((x) => x.Name.ToString() == textBox1.Text);

                    //만약에 동명이인을 넣고 싶을 경우!

                    List<Ranking> tempList = new List<Ranking>();
                    foreach (var item in data.rankings)
                    {
                        if (item.Name == textBox1.Text)
                            tempList.Add(item);
                    }


                    //MessageBox.Show("이름 : " + textBox1.Text);


                    //ranking.Rank = 1;
                    //ranking.Score = "123";
                    //ranking.Name = textBox1.Text;


                    dataGridView1.DataSource = null;

                    dataGridView1.DataSource = tempList;
                    //data.Save();


                }
                catch (Exception ex)
                {
                    string contents = "이름: " + textBox1.Text + "은 없습니다.";
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Ranking temp = dataGridView1.CurrentRow.DataBoundItem as Ranking;
                textBox1.Text = temp.Name.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);

            }
        }
        private void writeLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            //listBox1.Items.Add(logContents);
            //옛날 것이 가장 위에 올라가는 방식

            //새로운 것이 가장 위에 올라가는 방식
            listBox1.Items.Insert(0, logContents);
            data.printLog(logContents);
        }

        //writeLog() 오버로딩
        private void writeLog(string contents, string date)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            listBox1.Items.Insert(0, logContents);
            data.printLog(logContents, date);
        }
    }
}
