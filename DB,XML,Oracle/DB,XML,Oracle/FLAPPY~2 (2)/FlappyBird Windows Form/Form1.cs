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
    public partial class Form1 : Form
    {
        int pipeSpedd = 8;
        int gravity = 5;
        int score = 0;

        Random randX = new Random();
        Random randY = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimeEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpedd;
            pipeTop.Left -= pipeSpedd;
            scoreText.Text = "Score: " + score;

            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if(pipeTop.Left < -180)
            {  
                pipeTop.Left = 950;
                score++;
            }

            if (FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(ground.Bounds) || FlappyBird.Top < -25 
                )
            {
                endGame();
                MessageBox.Show("다시 시작하려면 확인을 누르세요");
                RestartGame();
            }

            if(score > 5)
            {
                pipeSpedd = 15;
            }
            if(score > 15)
            {
                pipeSpedd = 20;
            }
            if(score > 20)
            {
                pipeSpedd = 30;
            }
            
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;

            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;

            }
        }

        private void endGame()
        {
            gameTime.Stop();
            scoreText.Text = "Game Over!!!! ";

            Random r = new Random();
            WhatYourName temp = new WhatYourName(score);
            temp.ShowDialog();

            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void RestartGame()
        {            
                          
            score = 0;
            gravity = 5;
            pipeSpedd = 8;

            FlappyBird.Top = 172;
            pipeTop.Left = 272;
            pipeBottom.Left = 221;

            

            gameTime.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
