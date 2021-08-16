using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_Windows_Form
{
    public partial class WhatYourName : Form
    {
        private int score = 0;
        public WhatYourName(int score)
        {
            InitializeComponent();
            this.score = score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                MessageBox.Show("이름을 적어주세요.");
                return;
            }
            Ranking temp = new Ranking();
            temp.Name = textBox1.Text;
            temp.Score = this.score;
            temp.Rank = int.MaxValue;
            data.rankings.Add(temp);
            //MessageBox.Show(this.score.ToString());
            data.rankings.Sort();
            for (int i = 0; i < data.rankings.Count; i++)
            {
                data.rankings[i].Rank = (i + 1);
            }

            data.Save();
            Dispose();
        }
    }
}
