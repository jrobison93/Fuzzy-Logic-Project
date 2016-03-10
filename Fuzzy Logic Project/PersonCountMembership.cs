using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy_Logic_Project
{
    class PersonCountMembership
    {
        public static double Team(int people)
        {
            int low = 15;
            int platLow = 17;
            int platHigh = 20;
            int high = 20;

            if (people < low)
                return 0.0;
            if (people > high)
                return 1.0;

            return FuzzyAPI.PlateauProfile(people, low, high, platLow, platHigh);
        }

        public static double Many(int people)
        {
            int low = 8;
            int platLow = 10;
            int platHigh = 15;
            int high = 17;

            if (people < low || people > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(people, low, high, platLow, platHigh);
        }

        public static double Squad(int people)
        {
            int low = 4;
            int platLow = 5;
            int platHigh = 8;
            int high = 10;

            if (people < low || people > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(people, low, high, platLow, platHigh);
        }

        public static double Some(int people)
        {
            int low = 1;
            int platLow = 2;
            int platHigh = 4;
            int high = 5;

            if (people < low || people > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(people, low, high, platLow, platHigh);
        }

        public static double Few(int people)
        {
            int low = 0;
            int platLow = 0;
            int platHigh = 1;
            int high = 2;

            if (people < low)
                return 1.0;
            if (people > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(people, low, high, platLow, platHigh);
        }
    }
}
