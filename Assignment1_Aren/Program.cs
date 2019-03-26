using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomTypes;


namespace Assignment1_Aren
{
    public class Complex
    {
        private CustomDouble real, imag;
        
        public Complex() { imag.SetValue(0); real = imag; }
        public Complex(int x, int y)
        {
            real.SetValue(x);
            imag.SetValue(y);
        }
        
        public static Complex operator+ (Complex A, Complex B)
        {
            Complex C = new Complex();
            C.real = A.real + B.real;
            C.imag = A.imag + B.imag;
            return C;
        }
        public static Complex operator- (Complex A, Complex B)
        {
            Complex C = new Complex();
            C.real = A.real - B.real;
            C.imag = A.imag - B.imag;
            return C;
        }
        public static Complex operator* (Complex A, Complex B)
        {
            Complex C = new Complex();
            C.real = A.real * B.real - A.imag * B.imag;
            C.imag = A.real * B.imag + A.imag * B.real;
            return C;
        }
        public static Complex operator/ (Complex A, Complex B)
        {
            Complex C = new Complex();
            C.real = (A.real * B.real + A.imag * B.imag) / (B.real * B.real + B.imag * B.imag);
            C.imag = (A.imag * B.real - A.real * B.imag) / (B.real * B.real + B.imag * B.imag);
            
            C.real.SetValue(Math.Round(C.real.GetValue(), 3));
            C.imag.SetValue(Math.Round(C.imag.GetValue(), 3));
            return C;
        }

        public double Abs()
        {
            return Math.Round(Math.Sqrt((real * real + imag * imag).GetValue()),3);
        }

        public void Print()
        {
            if(real.GetValue()!=0) Console.Write(real.GetValue());
            if ((real.GetValue()!=0) && (imag.GetValue() > 0)) Console.Write('+');
            if ((real.GetValue()!=0) && imag.GetValue() == 1) { Console.WriteLine("i"); return; }
            if ((real.GetValue()!=0) && imag.GetValue() == -1) { Console.WriteLine("-i"); return; }
            if(imag.GetValue()!=0) {Console.WriteLine(imag.GetValue() + "i"); return;}
            if ((real.GetValue() != 0) && (imag.GetValue() == 0)) Console.WriteLine();
            if ((real.GetValue()==imag.GetValue())&&(real.GetValue()==0))Console.WriteLine(0);
        }
    }

    class Program
    {
        public static void StringToComplexNumbers(string S, ref int Real1, ref int Imag1)
        {
            int real1_is_negative = 0;
            if (S[0] == '-') real1_is_negative = 1;
            for (int i = real1_is_negative; i < S.Length - 1; ++i)
            {
                if ((S[i] == '+') || (S[i] == '-'))
                {
                    for (int j = real1_is_negative; j < i; ++j) { Real1 *= 10; Real1 += int.Parse(S[j].ToString()); }
                    if (S[S.Length - 2] == '+') Imag1 = 1;
                    else
                    if (S[S.Length - 2] == '-') Imag1 = -1;
                    else
                    {
                        for (int j = i + 1; j < S.Length - 1; ++j)
                        {
                            for (int k = j; k < S.Length - 1; ++k) { Imag1 *= 10; Imag1 += int.Parse(S[j].ToString()); }
                        }
                        if (S[i] == '-') Imag1 *= -1;
                    }
                }
            }
            if (real1_is_negative == 1) Real1 *= -1;
            if ((Real1 == 0) || (Imag1 == 0))
            {
                Console.WriteLine("Error. Please input correct numbers.");
                Console.ReadKey();
                Console.Clear();
                //goto here;
            };
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.Clear();
            
            string snum1, snum2;
            int real1 = 0, imag1 = 0, real2 = 0, imag2 = 0;
             
        //here-in case of wrong input program jumps here to read once again 
        here: Console.Write("Please input two complex numbers. For example: 7+9i or -1-8i\n" + "First number:\ta = ");
            snum1 = Console.ReadLine();
            Console.Write("Second number:\tb = ");
            snum2 = Console.ReadLine();
            Console.WriteLine();

            {//checking if the numbers are inputed correctly
                bool realpart_iscorrect = true;
                if ((snum1[0] == '+') || (snum2[0] == '0')) realpart_iscorrect = false;
                if ((snum1 == "i") || (snum2 == "i")) realpart_iscorrect = false;
                if (((snum1.LastIndexOf('+') == 0) && (!snum1.Contains('-'))) || ((snum1.LastIndexOf('-') == 0) && (!snum1.Contains('+')))) realpart_iscorrect = false;
                if ( (!snum1.Contains("+") && !snum1.Contains("-"))      ) realpart_iscorrect = false;

                if ((snum1 == "i") || (snum2 == "i")) realpart_iscorrect = false;
                if (((snum2.LastIndexOf('+') == 0)&&(!snum2.Contains('-'))) || ((snum2.LastIndexOf('-') == 0)&&(!snum2.Contains('+')))) realpart_iscorrect = false;
                if ((!snum2.Contains("+") && !snum2.Contains("-"))) realpart_iscorrect = false;

                if (  (    !(snum1.Contains('i') && snum2.Contains('i'))    ) || (!realpart_iscorrect)  )
                {
                    Console.WriteLine("Error. Please input correct numbers.");
                    Console.ReadKey();
                    Console.Clear();
                    goto here;
                }
            }
            
            StringToComplexNumbers(snum1,ref real1, ref imag1);//Converting the first input line to complex number variable
            StringToComplexNumbers(snum2, ref real2, ref imag2);//Converting the second input line to complex number variable

            {//Using the complex numbers

                Complex a = new Complex(real1, imag1);
                Complex b = new Complex(real2, imag2);

                //Adding and printing 2 complex numbers
                Complex gumar = new Complex();
                gumar = a + b;
                Console.Write("a+b = "); gumar.Print();

                //Substraction and printing 2 complex numbers
                Complex tarberutyun = new Complex();
                tarberutyun = a - b;
                Console.Write("a-b = "); tarberutyun.Print();

                //Multiplication and printing 2 complex numbers
                Complex artadryal = new Complex();
                artadryal = a * b;
                Console.Write("a*b = "); artadryal.Print();

                //Division and printing 2 complex numbers
                Complex haraberutyun = new Complex();
                haraberutyun = a / b;
                Console.Write("a/b = "); haraberutyun.Print();

                //Calculating the absolute values of 2 complex numbers
                Console.WriteLine("|a| = " + a.Abs());
                Console.WriteLine("|b| = " + b.Abs());
            }

            {//Operations with CustomType type variables
                Console.WriteLine("\n----------------------------------\n");
                CustomTypes.CustomInt FirstInt = new CustomTypes.CustomInt(4);
                CustomInt SecondInt;
                SecondInt = FirstInt;
                SecondInt++;
                Console.WriteLine("FirstInt = " + FirstInt.GetValue());
                Console.WriteLine("SecondInt = " + SecondInt.GetValue());
                Console.WriteLine("FirstInt + SecondInt = " + (FirstInt + SecondInt).ToString() + "\n");

                
                CustomTypes.CustomDouble FirstDouble = new CustomTypes.CustomDouble(4);
                CustomDouble SecondDouble;
                SecondDouble = FirstDouble;
                Console.WriteLine("FirstDouble = " + FirstDouble.GetValue());
                Console.WriteLine("SecondDouble = " + FirstDouble.GetValue());
                Console.WriteLine("FirstDouble + SecondDouble = " + (FirstDouble + SecondDouble).ToString() + "\n");
            }

            Console.ReadKey();
        }
    }
}