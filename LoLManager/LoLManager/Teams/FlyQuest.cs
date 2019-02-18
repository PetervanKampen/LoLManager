using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class FlyQuest : Team
    {
        public FlyQuest()
        {
            teamName = "FlyQuest";
            logo = global::LoLManager.Properties.Resources.FlyQuest;
            topLane = new Viper();
            jungle = new Santorin();
            mid = new Pobelter();
            adc = new WildTurtle();
            support = new JayJ();
            coach = new Invert();
        }
    }
}
