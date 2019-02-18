using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class Echo_Fox : Team
    {
        public Echo_Fox()
        {
            teamName = "Echo Fox";
            logo = global::LoLManager.Properties.Resources.Echo_Fox;
            jersey = global::LoLManager.Properties.Resources.Echo_FoxJersey;
            money = 10000;


            topLane = new Solo();
            jungle = new Rush();
            mid = new Fenix();
            adc = new Apollo();
            support = new Hakuho();

            coach = new SSong();
        }
    }
}
