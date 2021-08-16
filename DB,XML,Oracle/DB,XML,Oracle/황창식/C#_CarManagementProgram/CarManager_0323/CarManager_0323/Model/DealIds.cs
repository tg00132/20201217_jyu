using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_0323.Model
{
    class DealIds
    {
        private int d_id;
        private int s_id;
        private int cus_id;
        private int car_id;

        public DealIds(int d_id, int id, int cus_id, int car_id)
        {
            this.d_id = d_id;
            s_id = id;
            this.cus_id = cus_id;
            this.car_id = car_id;
        }

        public int D_id { get => d_id; set => d_id = value; }
        public int S_id { get => s_id; set => s_id = value; }
        public int Cus_id { get => cus_id; set => cus_id = value; }
        public int Car_id { get => car_id; set => car_id = value; }
    }
}
