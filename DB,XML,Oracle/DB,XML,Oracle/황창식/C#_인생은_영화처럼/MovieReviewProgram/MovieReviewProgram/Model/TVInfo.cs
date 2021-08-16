using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReviewProgram.Model
{
    class TVInfo
    {
        private int id;
        private string name;
        private string country;

        public TVInfo(int id, string name, string country)
        {
            this.id = id;
            this.name = name;
            this.country = country;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
    }
}
