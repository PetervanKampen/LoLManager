using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class Cloud9 : Team
    {
        public Cloud9()
        {
            teamName = "Cloud 9";
            logo = global::LoLManager.Properties.Resources.C9;
            topLane = new Licorice();
            jungle = new Svenskeren();
            mid = new Nisqy();
            adc = new Sneaky();
            support = new Zeyzal();
            coach = new Reapered();
        }
    }
}
