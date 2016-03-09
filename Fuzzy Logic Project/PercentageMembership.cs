using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy_Logic_Project
{
    class PercentageMembership
    {
        public static double High(int percent)
        {
            int low = 75;
            int platLow = 80;
            int platHigh = 100;
            int high = 100;

            if (percent < low)
                return 0.0;
            if (percent > high)
                return 1.0;

            return FuzzyAPI.PlateauProfile(percent, low, high, platLow, platHigh);
        }

        public static double MediumHigh(int percent)
        {
            int low = 60;
            int platLow = 65;
            int platHigh = 75;
            int high = 80;

            if (percent < low || percent > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(percent, low, high, platLow, platHigh);
        }

        public static double Medium(int percent)
        {
            int low = 25;
            int platLow = 30;
            int platHigh = 60;
            int high = 65;

            if (percent < low || percent > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(percent, low, high, platLow, platHigh);
        }

        public static double MediumLow(int percent)
        {
            int low = 10;
            int platLow = 15;
            int platHigh = 25;
            int high = 30;

            if (percent < low || percent > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(percent, low, high, platLow, platHigh);
        }

        public static double Low(int percent)
        {
            int low = 0;
            int platLow = 0;
            int platHigh = 10;
            int high = 15;

            if (percent < low)
                return 1.0;
            if (percent > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(percent, low, high, platLow, platHigh);
        }
    }
}
