using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class OpTic_Gaming : Team
    {
        public OpTic_Gaming()
        {
            teamName = "OpTic Gaming";
            shortName = teamName;
            logo = global::LoLManager.Properties.Resources.OpTic_Gaming;
            jersey = global::LoLManager.Properties.Resources.OpTic_GamingJersey;
            money = 10000;


            topLane = new Dhokla();
            jungle = new Meteos();
            mid = new Crown();
            adc = new Arrow();
            support = new Big();

            coach = new Zaboutine();
        }
    }
}
