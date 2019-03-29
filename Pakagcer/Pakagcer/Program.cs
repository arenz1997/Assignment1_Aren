using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakagcer
{
    class Program
    {
        static void Main(string[] args)
        {
            here:
            Console.WriteLine("Hello! Please enter some brackets.");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            if (s.Length == 0)
            {
                Console.Clear();
                goto here;
            }
            for (int i = 0; i < s.Length; ++i)
                if ((s[i] != '(') && (s[i] != ')') && (s[i] != '{') && (s[i] != '}') && (s[i] != '[') && (s[i] != ']'))
                {
                    Console.WriteLine("Please enter only brackets");
                    Console.Clear();
                    goto here;
                }

            if ((s.Length == 1) || (s[0] == ')') || (s[0] == '}') || (s[0] == ']'))
            {
                Console.WriteLine("NO");
            }//for example: s is '(' or '{' or '['  OR starts with ')' or '}' or ']'
            else
            for (int j = 0; j < s.Length - 1; ++j)//  "((((())"  length = 7, jMax == 5
            {
                    if (
                        ((s[j] == '(') && (s[j + 1] == '}')) || //   "...(}..."
                        ((s[j] == '(') && (s[j + 1] == ']')) || //   "...(]..."
                        ((s[j] == '{') && (s[j + 1] == ')')) || //   "...{)..."
                        ((s[j] == '{') && (s[j + 1] == ']')) || //   "...{]..."
                        ((s[j] == '[') && (s[j + 1] == ')')) || //   "...[)..."
                        ((s[j] == '[') && (s[j + 1] == '}'))    //   "...[}..."
                       )
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                    if (((s[j] == '(') && (s[j + 1] == ')')) ||//   "...()..."
                        ((s[j] == '{') && (s[j + 1] == '}')) ||//   "...{}..."
                        ((s[j] == '[') && (s[j + 1] == ']')))  //   "...[]..."
                    {
                        s.Remove(j, 2); // "(({})" -> "(()"
                        j = -1; //because in for loop j becomes 0 after ++j
                        if (s.Length == 0)// no bracket
                        {
                            Console.WriteLine("YES");
                            break;
                        }
                        if (s.Length == 1)// only one bracket
                        {
                            Console.WriteLine("NO");
                            break;
                        }
                    } else if (j == s.Length - 2)// 
                    {//   "(((" length=3, j=1. if the j indicates the last character and s[j] and s[j+1] stay in wrong order
                        Console.WriteLine("NO");
                        break;
                    }
                }
        Console.ReadKey();
        }
    }
}