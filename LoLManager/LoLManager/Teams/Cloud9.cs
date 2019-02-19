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
            shortName = teamName;
            logo = global::LoLManager.Properties.Resources.C9;
            jersey = global::LoLManager.Properties.Resources.C9Jersey;
            money = 15000;


            topLane = new Licorice();
            jungle = new Svenskeren();
            mid = new Nisqy();
            adc = new Sneaky();
            support = new Zeyzal();

            coach = new Reapered();
        }
    }
}
