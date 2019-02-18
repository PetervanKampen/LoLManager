using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class Golden_Guardians : Team
    {
        public Golden_Guardians()
        {
            teamName = "Golden Guardians";
            logo = global::LoLManager.Properties.Resources.Golden_Guardians;
            topLane = new Hauntzer();
            jungle = new Contractz();
            mid = new Froggen();
            adc = new Deftly();
            support = new Olleh();
            coach = new Inero();
        }
    }
}
