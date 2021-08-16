using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird_Windows_Form
{
    class Ranking: IComparable //IComparable 인터페이스 상속하기 Ranking 클래스의 정렬 기준을 정해주기 위해 IComparable 인터페이스 구현

    {
        private int rank;
        private int score;
        private string name;

        public int Rank { get => rank; set => rank = value; }
        public int Score { get => score; set => score = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Time { get; set; }

        public int CompareTo(object obj)
        {
            //return score.CompareTo( (obj as Ranking).score ); //오름차순
            return (obj as Ranking).score.CompareTo(this.score); // 내림차순
        }
    }

}
