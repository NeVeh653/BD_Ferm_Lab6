 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd_app
{
    class Machinery
    {
        public int id_machinery { get; set; }
        public float cost { get; set; }
        public string status { get; set; }
        public string type_of_machine { get; set; }
        

        public Machinery(int id_machinery, float cost, string status, string type_of_machine)
        {
            this.id_machinery = id_machinery;
            this.cost = cost;
            this.status = status;
            this.type_of_machine = type_of_machine;
        }
    }
}
