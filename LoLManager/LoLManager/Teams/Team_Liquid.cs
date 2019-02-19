using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class Team_Liquid : Team
    {
        public Team_Liquid()
        {
            teamName = "Team Liquid";
            shortName = teamName;
            logo = global::LoLManager.Properties.Resources.Team_Liquid;
            jersey = global::LoLManager.Properties.Resources.Team_LiquidJersey;
            money = 10000;


            topLane = new Impact();
            jungle = new Xmithie();
            mid = new Jensen();
            adc = new Doublelift();
            support = new CoreJJ();

            coach = new Cain();
        }
    }
}
