using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gregson.Capston
{
    class ImperialToMetric
    {
        private double centimeters;
        private int meters;
        private int kilometers;

        public bool imperialToMetric(string userInches, string userFeet, string userYards, string userMiles)
        {
            try
            {
                Convert.ToInt32(userInches);
                Convert.ToInt32(userFeet);
                Convert.ToInt32(userMiles);
                Convert.ToInt32(userYards);

                
            }
            catch
            {
                return false;
            }

            double totalMiles = (double.Parse(userMiles));
            double totalYards = convertMilesToYards(double.Parse(userMiles)) + Convert.ToInt32(userYards);
            double totalFeet = convertYardsToFeet(totalYards) + Convert.ToInt32(userFeet);
            double totalInches = convertFeetToInches(totalFeet) + Convert.ToInt32(userInches);

            centimeters = inchesToCentimeters(totalInches);

            meters  = convertCentimetersToMeters(centimeters);

            kilometers = convertMetersToKilometers(meters);

            return true;

        }

        public double convertMilesToYards(double a)
        {
            return a * 1760;
        }

        public double convertYardsToFeet(double a)
        {
            return a * 3;
        }

        public double convertFeetToInches(double a)
        {
            return Convert.ToDouble(a) * 12;
        }

        public double inchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }

        public  int convertCentimetersToMeters(double centi)
        {
            return (int)centi / 100;
        }

        public int convertMetersToKilometers(double meters)
        {
            return (int)meters / 1000; ;
        }

        public string getCentimeters()
        {
            return Convert.ToString(centimeters);
        }

        public string getMeters()
        {
            return Convert.ToString(meters);
        }

        public string getKilometers()
        {
            return Convert.ToString(kilometers);
        }















    }
}