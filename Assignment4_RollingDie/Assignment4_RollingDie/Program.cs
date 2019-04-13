using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_RollingDie
{
    class Program
    {
        public static void Double4Handler(object source, DiceEventArgs e )
        {
            Console.WriteLine("two fours in a row");
            doubleCount++;
        }

        public static void Sum20Handler(object source, DiceEventArgs e)
        {
            Console.Write(e.die_List[e.I].ToString() + "+" + e.die_List[e.I + 1].ToString() + "+" + e.die_List[e.I + 2].ToString() + "+" + e.die_List[e.I + 3].ToString() + "+" + e.die_List[e.I + 4].ToString() + "=");
            Console.WriteLine(e.die_List[e.I]+e.die_List[e.I + 1]+e.die_List[e.I + 2]+e.die_List[e.I + 3]+e.die_List[e.I + 4]);
            Console.WriteLine("Sum of 5 elements is greater than 20");
        }
        public static int doubleCount = 0;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            List<int> diceList = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 50; ++i)
            {
                diceList.Add(rnd.Next(1,6));
                Console.Write(diceList[i]+" ");
            }
            Console.WriteLine();
            DiceChecker diceChecker = new DiceChecker(diceList);
            diceChecker.HasDouble4 += Double4Handler;
            diceChecker.HasSum20 += Sum20Handler;
            diceChecker.Check_Double4();
            if (doubleCount != 0) Console.WriteLine(doubleCount + "x two fours\n");
            diceChecker.Check_Sum20();
        }
    }
}