using System;
using PigRace.Business;

namespace PigRace
{
    public static class Factory
    {
        public static Punter GetAPunter(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new MadButcher();
                case 1:
                    return new FarmerBrown();
                case 2:
                    return new MrsPiggy();

                default: return null;
            }
        }
    }
}