using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_0323.Model
{
    class Seller
    {
        private string name;
        private string tel;
        private string email;
        private string grade;
        private string derijum;

        public Seller(string name, string tel, string email, string grade, string derijum)
        {
            this.name = name;
            this.tel = tel;
            this.email = email;
            this.grade = grade;
            this.derijum = derijum;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Grade { get => grade; set => grade = value; }
        public string Derijum { get => derijum; set => derijum = value; }
    }
}