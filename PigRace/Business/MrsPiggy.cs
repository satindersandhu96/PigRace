using PigRace.Business;

namespace PigRace
{
    class MrsPiggy : Punter
    {
        public MrsPiggy()
        {
            // set up values for punter
            PunterName = "Mrs Piggy";
            Pig = "";
            Cash = 50;
            Broke = false;
        }
    }
}