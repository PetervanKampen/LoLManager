using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class NATeams
    {
        public Team thieves;
        public Team c9;
        public Team cg;
        public Team clg;
        public Team efx;
        public Team fly;
        public Team ggs;
        public Team opt;
        public Team tl;
        public Team tsm;

        public NATeams()
        {
            thieves = new Thieves();
            c9 = new Cloud9();
            cg = new Clutch_Gaming();
            clg = new Counter_Logic_Gaming();
            efx = new Echo_Fox();
            fly = new FlyQuest();
            ggs = new Golden_Guardians();
            opt = new OpTic_Gaming();
            tl = new Team_Liquid();
            tsm = new Team_SoloMid();
        }
    }
}
