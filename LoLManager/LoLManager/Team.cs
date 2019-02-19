using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLManager
{
    class Team
    {
        public String teamName;
        public String shortName;
        public System.Drawing.Bitmap logo;
        public System.Drawing.Bitmap jersey;

        public int money;

        public Player topLane;
        public Player jungle;
        public Player mid;
        public Player adc;
        public Player support;

        public Coach coach;

        public int wins = 0;
        public int losses = 0;
    }
}
