using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_0323.Model
{
    class Deal
    {
        private Customer customer;
        private Car car;
        private Seller seller;

        public Deal(Customer customer, Car car, Seller seller)
        {
            this.customer = customer;
            this.car = car;
            this.seller = seller;
        }

        internal Customer Customer { get => customer; set => customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal Seller Seller { get => seller; set => seller = value; }
    }
}
