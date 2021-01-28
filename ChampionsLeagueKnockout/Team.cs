using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeagueKnockout
{
    public class Team
    {
        
        public string Name { get; set; }
        public string Country { get; set; }
        public int Strength { get; set; }
        public int Points { get; set; }
        public string NamePoints
        {
            get
            {
                return Name + " " + Points.ToString();
            }

        }
        
    }
}
