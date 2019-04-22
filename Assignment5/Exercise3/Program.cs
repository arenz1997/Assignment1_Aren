using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting the file path location
            StreamReader Reader = new StreamReader(@"C:\Users\arenz\source\repos\Homeworks\Assignment5\Exercise3\Test data for Exercise 3.txt");
            
            //Creating a list of Airports
            List<Airport> airportList = new List<Airport>();

            //Reading the airport list from "Test data for Exercise 3.txt" and adding it in List - "airportList"
            while (!Reader.EndOfStream)
            {
                string line = Reader.ReadLine();
                string[] columns = line.Split(' ');
                Airport airport = new Airport()
                {
                    Name = columns[0],
                    CountryCode = columns[1],
                    Size = columns[2]
                };
                if(line.Contains("Super Mega")) airport.Size += " Mega";
                airportList.Add(airport);
            }

            //Calling the static method from "Airport" class which recieves the reference of airportList
            Airport.SortAirports(ref airportList);

            //Printing the final sorted airpotList
            foreach (var airport in airportList)
            {
                Console.WriteLine(airport.Name + "\t" + airport.CountryCode + "\t" + airport.Size);
            }
        }
    }
}