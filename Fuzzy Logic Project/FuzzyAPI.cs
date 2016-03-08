using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy_Logic_Project
{
    class FuzzyAPI
    {

        public static double FuzzyAnd(double a, double b)
        {
            return Math.Min(a, b);
        }

        public static double FuzzyOr(double a, double b)
        {
            return Math.Max(a, b);
        }

        public static double FuzzyNot(double a)
        {
            return (1.0 - a);
        }

        public static double SpikeProfile(double value, double low, double high)
        {
            double peak;
            value += (-low);
            if ((low < 0) && (high < 0))
            {
                high = -(high - low);
            }
            else if ((low < 0) && (high > 0))
            {
                high += -low;
            }
            else if ((low > 0) && (high > 0))
            {
                high -= low;
            }

            peak = (high / 2.0);
            low = 0.0;
            if (value < peak)
            {
                return value / peak;
            }
            else if (value > peak)
            {
                return (high - value) / peak;
            }
            return 1.0;
        }

        public static double PlateauProfile(double value, double low, double high, double platLow, double platHigh)
        {
            double upSlope;
            double downSlope;
            value += (-low);

            if (low < 0.0)
            {
                platLow += -low;
                platHigh += -low;
                high += -low;
                low = 0.0;
            }
            else
            {
                platLow -= low;
                platHigh -= low;
                high -= low;
                low = 0.0;
            }

            upSlope = (1.0 / (platLow - low));
            downSlope = (1.0 / (high - platHigh));

            if (value < low)
                return 0.0;
            else if (value > high)
                return 0.0;
            else if (value >= platLow && value <= platHigh)
                return 1.0;
            else if (value < platLow)
                return (value - low) * upSlope;
            else if (value > platHigh)
                return (high - value) * downSlope;
            return 0.0;
        }

    }
}
