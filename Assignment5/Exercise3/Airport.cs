using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Airport
    {
        public static void SortAirports(ref List<Airport> airports)
        {
            //"Converting" the string sizes to int sizes...
            foreach(var airport in airports)
            {
                switch (airport.Size)
                {
                    case "Small":
                        {
                            airport.SizeInt = 0;
                            break;
                        }
                    case "Medium":
                        {
                            airport.SizeInt = 1;
                            break;
                        }
                    case "Large":
                        {
                            airport.SizeInt = 2;
                            break;
                        }
                    case "Mega":
                        {
                            airport.SizeInt = 3;
                            break;
                        }
                    case "Super Mega":
                        {
                            airport.SizeInt = 4;
                            break;
                        }
                    default: break;
                }
            }

            //Sorting with bubble sort algorithm
            Airport temp = new Airport();
            for(int i = 0; i < airports.Count; ++i)
            {
                for(int j = 0; j < airports.Count; ++j)
                {
                    if (airports[i].SizeInt > airports[j].SizeInt)
                    {
                        temp = airports[i];
                        airports[i] = airports[j];
                        airports[j] = temp;
                    }
                }
            }

        }

        //The main fields of Airport class
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Size { get; set; }
        public int SizeInt { get; set; }
    }
}