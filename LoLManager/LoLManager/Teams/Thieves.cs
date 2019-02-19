using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class Thieves : Team
    {
        public Thieves()
        {
            teamName = "100 Thieves";
            shortName = teamName;
            logo = global::LoLManager.Properties.Resources._100T;
            jersey = global::LoLManager.Properties.Resources._100TJersey;
            money = 10000;


            topLane = new Ssumday();
            jungle = new Anda();
            mid = new Huhi();
            adc = new Bang();
            support = new Aphromoo();

            coach = new Prolly();
        }
    }
}
