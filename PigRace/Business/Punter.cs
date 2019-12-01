using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigRace.Business
{
    public abstract class Punter
    {
        public string PunterName { get; set; }
        public string Pig { get; set; }
        public Single Cash { get; set; }
        public Single Bet { get; set; }
        public bool Broke { get; set; }
    }
}
