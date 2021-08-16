using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird_Windows_Form
{
    class Ranking: IComparable
    {
        private int rank;
        private int score;
        private string name;

        public int Rank { get => rank; set => rank = value; }
        public int Score { get => score; set => score = value; }
        public string Name { get => name; set => name = value; }

        public int CompareTo(object obj)
        {
            //return score.CompareTo( (obj as Ranking).score ); //오름차순
            return (obj as Ranking).score.CompareTo(this.score); // 내림차순
        }
    }

}
