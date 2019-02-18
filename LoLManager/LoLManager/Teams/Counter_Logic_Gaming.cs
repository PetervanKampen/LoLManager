using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class Counter_Logic_Gaming : Team
    {
        public Counter_Logic_Gaming()
        {
            teamName = "Counter Logic Gaming";
            logo = global::LoLManager.Properties.Resources.CLG;
            topLane = new Darshan();
            jungle = new Wiggily();
            mid = new PowerOfEvil();
            adc = new Stixxay();
            support = new Biofrost();
            coach = new Weldon();
        }
    }
}
