using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy_Logic_Project
{
    class DistanceMembership
    {
        public static double VeryFar(int distance)
        {
            int low = 600;
            int platLow = 650;
            int platHigh = 650;
            int high = 650;

            if (distance < low)
                return 0.0;
            if (distance > high)
                return 1.0;

            return FuzzyAPI.PlateauProfile(distance, low, high, platLow, platHigh);
        }

        public static double Far(int distance)
        {
            int low = 450;
            int platLow = 500;
            int platHigh = 600;
            int high = 650;

            if (distance < low || distance > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(distance, low, high, platLow, platHigh);
        }

        public static double MidRange(int distance)
        {
            int low = 300;
            int platLow = 350;
            int platHigh = 450;
            int high = 500;

            if (distance < low || distance > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(distance, low, high, platLow, platHigh);
        }

        public static double Near(int distance)
        {
            int low = 150;
            int platLow = 200;
            int platHigh = 300;
            int high = 350;

            if (distance < low || distance > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(distance, low, high, platLow, platHigh);
        }

        public static double CloseRange(double distance)
        {
            int low = 10;
            int platLow = 60;
            int platHigh = 150;
            int high = 200;

            if (distance < low || distance > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(distance, low, high, platLow, platHigh);
        }

        public static double MeleeRange(int distance)
        {
            int low = 0;
            int platLow = 0;
            int platHigh = 5;
            int high = 10;
            
            if (distance < low)
                return 1.0;
            if (distance > high)
                return 0.0;

            return FuzzyAPI.PlateauProfile(distance, low, high, platLow, platHigh);
        }
    }
}
