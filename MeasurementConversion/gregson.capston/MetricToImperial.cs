using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gregson.Capston
{
    class MetricToImperial
    {
        private double inches;
        private int feet;
        private int yards;
        private int miles;

        public bool metricToImperial(string userCentimeters, string userMeters, string userKilometers)
        {
            try
            {
                Convert.ToInt32(userCentimeters);
                Convert.ToInt32(userMeters);
                Convert.ToInt32(userKilometers);
            }
            catch
            {
                return false;
            }

            int totalKilometers = (int.Parse(userKilometers));
            int totalMeters = convertKilometersToMeters(int.Parse(userKilometers)) + Convert.ToInt32(userMeters);
            double totalCentimeters = convertMetersToCentimeters(int.Parse(userMeters)) + Convert.ToInt32(userCentimeters);

            inches = convertCentimetersToInches(totalCentimeters);

            feet = convertInchesToFeet(Convert.ToInt32(inches));

            yards = convertFeetToYards(Convert.ToInt32(feet));

            miles = convertYardsToMiles(Convert.ToInt32(yards));

            return true;
        }

        public int convertKilometersToMeters(int a)
        {
            return a * 1000;
        }

        public int convertMetersToCentimeters(int a)
        {
            return a * 100;
        }

        public double convertCentimetersToInches(double centimeters)
        {
            return centimeters / 2.54;
        }

        public int convertInchesToFeet(int a)
        {
            return a / 12;
        }

        public int convertFeetToYards(int a)
        {
            return a / 3;
        }

        public int convertYardsToMiles(int a)
        {
            return a / 1760;
        }

        public string getInches()
        {
            return Convert.ToString(inches);
        }

        public string getFeet()
        {
            return Convert.ToString(feet);
        }

        public string getYards()
        {
            return Convert.ToString(yards);
        }

        public string getMiles()
        {
            return Convert.ToString(miles);
        }
    }
}
