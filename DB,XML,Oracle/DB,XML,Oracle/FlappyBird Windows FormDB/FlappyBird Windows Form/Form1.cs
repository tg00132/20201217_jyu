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
        int pipeSpeed = 8;   //파이프 기본 속도
        int gravity = 5;     // 중력
        int score = 0;       // 점수

        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimeEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity; // 새의 윗부분에서 부터 중력을 더해준다

            pipeBottom.Left -= pipeSpeed; //pipeBottom 왼쪽으로 pipeSpeed 만큼뺀다

            pipeTop.Left -= pipeSpeed;    //pipeTop.Left 왼쪽으로 pipeSpeed 만큼뺀다
            scoreText.Text = "Score: " + score;



            if(pipeBottom.Left < -150)  // pipeBottom.Left  -150픽셀 을 넘어가면 pipeBottom.Left 800픽셀에 다시 생성되며
            {                           // score가 올라감
                pipeBottom.Left = 800;
                score++;
            }
            if(pipeTop.Left < -180)    // pipeBottom.Left  -180픽셀 을 넘어가면 pipeBottom.Left 950픽셀에 다시 생성되며
            {                          // score가 올라감
                pipeTop.Left = 950;    
                score++;
            }

            if (FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || // pipeBottom 을 부딪히거나
                FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||    // pipeTop 을 부딪히거나
                FlappyBird.Bounds.IntersectsWith(ground.Bounds) ||     // ground 에 부딪히거나
                FlappyBird.Top < -25                                   // 새의 윗부분이 -25픽셀을 넘어갈 경우
                )
            {
                endGame();                                             // 게임이 끝나면서 메세지박스를 출력한다
                if (DialogResult.Yes == MessageBox.Show("다시 시작 하시겠습니까??","Game Over", MessageBoxButtons.YesNo))
                {
                    Application.Restart();                             //MessageBox의 예를 누를경우
                }
                else
                {
                    this.Close();                                       //MessageBox의 아니오를 누를경우
                }               
            }

            if(score > 5)           // 스코어가 5를 넘어가면 파이프 스피드가 15로
            {
                pipeSpeed = 15;
            }
            if(score > 15)         // 스코어가 15를 넘어가면 파이프 스피드가 20으로
            {
                pipeSpeed = 20;
            }
            if(score > 20)          // 스코어가 20를 넘어가면 파이프 스피드가 30으로
            {                       // 증가한다.
                pipeSpeed = 30;
            }
            
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;            // 스페이스 키를 누르면 중력이 -10로 변환되며 새가 올라간다.

            }
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;               // 스페이스 키에서 손을때면 중력을 다시 받아 새가 내려간다.

            }
        }

        private void endGame()
        {
            
            gameTime.Stop();
            scoreText.Text = "Game Over!!!! ";               
            who temp = new who(score);             
            temp.ShowDialog();
            RankingList rankingList = new RankingList();           
            rankingList.ShowDialog();
           
        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void RestartGame()
        {            
                          
            /*score = 0;
            gravity = 5;
            pipeSpeed = 8;

            FlappyBird.Top = 172;
            pipeTop.Left = 272;
            pipeBottom.Left = 221;            
            gameTime.Start();*/

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
