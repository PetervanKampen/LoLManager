using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{ 
    class Team_SoloMid : Team
    {
        public Team_SoloMid()
        {
            teamName = "Team SoloMid";
            shortName = "TSM";
            logo = global::LoLManager.Properties.Resources.Team_SoloMid;
            jersey = global::LoLManager.Properties.Resources.Team_SoloMidJersey;
            money = 10000;


            topLane = new Broken_Blade();
            jungle = new Akaadian();
            mid = new Bjergsen();
            adc = new Zven();
            support = new Smoothie();

            coach = new Zikz();
        }
    }
}
