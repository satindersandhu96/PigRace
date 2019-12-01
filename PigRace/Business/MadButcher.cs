using PigRace.Business;

namespace PigRace
{
    class MadButcher : Punter
    {
        public MadButcher()
        {
            // set up values for punter
            PunterName = "Mad Butcher";
            Pig = "";
            Cash = 50;
            Broke = false;
        }
    }
}