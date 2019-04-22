using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputName and outName...
            string inputLine = Console.ReadLine(), outLine = "";
            
            //loop goes from first element to penultimate element because of my if-conditions
            //the last element will be checked after "for loop"
            for (int i = 0; i < inputLine.Length - 1; ++i)
            {
                if (char.IsUpper(inputLine[i]))
                {
                    outLine += inputLine[i];
                    continue;
                }
                if ((inputLine[i] == '-')|| (inputLine[i] == '+') || (inputLine[i] == '*') || (inputLine[i] == '/')||
                    (inputLine[i] == '.') || (inputLine[i] == '&') || (inputLine[i] == '!'))
                {
                    outLine += char.ToUpper(inputLine[i + 1]);
                    ++i;
                    continue;
                }
            }

            //here is checking the last element
            if (char.IsUpper(inputLine[inputLine.Length - 1]))
            {
                outLine += inputLine[inputLine.Length-1];
            }
            Console.WriteLine(outLine);
        }
    }
}