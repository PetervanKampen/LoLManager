using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class Clutch_Gaming : Team
    {
        public Clutch_Gaming()
        {
            teamName = "Clutch Gaming";
            logo = global::LoLManager.Properties.Resources.Clutch_Gaming;
            topLane = new Huni();
            jungle = new LirA();
            mid = new Damonte();
            adc = new Piglet();
            support = new Vulcan();
            coach = new mcscrag();
        }
    }
}
