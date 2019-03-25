using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypesByAren;


namespace Assignment1_Aren
{
    public class Complex
    {
        private DoubleByAren real, imag;
        
        public Complex() { imag.SetValue(0); real = imag; }
        public Complex(int x, int y)
        {
            real.SetValue(x);
            imag.SetValue(y);
        }
        ~Complex() { }
        
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
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.Clear();

            string snum1, snum2;//string tipi complex tveri popoxakanner
            int real1 = 0, imag1 = 0, real2 = 0, imag2 = 0;//int tipi complex tveri popoxakanner

        //here-sxal mutqagrelu demqum goto e linum ays nshich
        here: Console.Write("Please input two complex numbers. For example: 7+9i or -1-8i\n" + "First number:\ta = ");
            snum1 = Console.ReadLine();
            Console.Write("Second number:\tb = ");
            snum2 = Console.ReadLine();
            Console.WriteLine();

            {//stugum e mutqagrvac tvyalner@ chisht en
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
            }//mutqagrvac tvyalner@ stugelu verj

            {//arajin tvi arandznacum
                int real1_is_negative = 0;
                if (snum1[0] == '-') real1_is_negative = 1;
                for (int i = real1_is_negative; i < snum1.Length-1; ++i)
                {
                    if ((snum1[i] == '+') || (snum1[i] == '-'))
                    {
                        for (int j = real1_is_negative; j < i; ++j) { real1 *= 10; real1 += int.Parse(snum1[j].ToString()); }
                        if (snum1[snum1.Length - 2] == '+') imag1 = 1; else
                        if (snum1[snum1.Length - 2] == '-') imag1 = -1; else
                        {
                            for (int j = i + 1; j < snum1.Length - 1; ++j)
                            {
                                for (int k = j; k < snum1.Length - 1; ++k) { imag1 *= 10; imag1 += int.Parse(snum1[j].ToString()); }
                            }
                            if (snum1[i] == '-') imag1 *= -1;
                        }
                    }
                }
                if (real1_is_negative == 1) real1 *= -1;
                if ((real1 == 0) || (imag1 == 0)) {
                    Console.WriteLine("Error. Please input correct numbers.");
                    Console.ReadKey();
                    Console.Clear();
                    goto here;
                };
            }//1-in tvi arandznacman verj

            {//2-rd tvi arandznacum
                int real2_is_negative = 0;
                if (snum2[0] == '-') real2_is_negative = 1;
                for (int i = real2_is_negative; i < snum2.Length-1; ++i)
                {
                    if ((snum2[i] == '+') || (snum2[i] == '-'))
                    {
                        for (int j = real2_is_negative; j < i; ++j) { real2 *= 10; real2 += int.Parse(snum2[j].ToString()); }
                        if (snum2[snum2.Length - 2] == '+') imag2 = 1;
                        else
                        if (snum2[snum2.Length - 2] == '-') imag2 = -1;
                        else
                        {
                            for (int j = i + 1; j < snum2.Length - 1; ++j)
                            {
                                for (int k = j; k < snum2.Length - 1; ++k) { imag2 *= 10; imag2 += int.Parse(snum2[j].ToString()); }
                            }
                            if (snum2[i] == '-') imag2 *= -1;
                        }
                    }
                }
                if (real2_is_negative == 1) real2 *= -1;
                if ((real2 == 0) || (imag2 == 0)) { Console.WriteLine("Error. Please input correct numbers.");
                    Console.ReadKey();
                    Console.Clear();
                    goto here;};
            }//2-rd tvi arandznacman verj

            

            {//gorcoxutyunner complex tveri het
                //complex tveri objectneri stexcum
                Complex a = new Complex(real1, imag1);
                Complex b = new Complex(real2, imag2);

                //hashvum e ev tpum a+b
                Complex gumar = new Complex();
                gumar = a + b;
                Console.Write("a+b = "); gumar.Print();

                //hashvum e ev tpum a-b
                Complex tarberutyun = new Complex();
                tarberutyun = a - b;
                Console.Write("a-b = "); tarberutyun.Print();

                //hashvum e ev tpum a*b
                Complex artadryal = new Complex();
                artadryal = a * b;
                Console.Write("a*b = "); artadryal.Print();

                //hashvum e ev tpum a/b
                Complex haraberutyun = new Complex();
                haraberutyun = a / b;
                Console.Write("a/b = "); haraberutyun.Print();

                //Abs() methodov hashvum ev tpum e mutqagrvac tveri modul@-Absolute
                Console.WriteLine("|a| = " + a.Abs());
                Console.WriteLine("|b| = " + b.Abs());
            }//complex tveri het gorcoxutyunneri verj 
            {//TypeAren-i het gorcoxutyunner
                Console.WriteLine("\n----------------------------------\n");
                TypesByAren.IntByAren FirstInt = new TypesByAren.IntByAren(4);
                IntByAren SecondInt;
                SecondInt = FirstInt;
                SecondInt++;
                Console.WriteLine("FirstInt = " + FirstInt.GetValue());
                Console.WriteLine("SecondInt = " + SecondInt.GetValue());
                Console.WriteLine("FirstInt + SecondInt = " + (FirstInt + SecondInt).ToString() + "\n");

                
                TypesByAren.DoubleByAren FirstDouble = new TypesByAren.DoubleByAren(4);
                DoubleByAren SecondDouble;
                SecondDouble = FirstDouble;
                Console.WriteLine("FirstDouble = " + FirstDouble.GetValue());
                Console.WriteLine("SecondDouble = " + FirstDouble.GetValue());
                Console.WriteLine("FirstDouble + SecondDouble = " + (FirstDouble + SecondDouble).ToString() + "\n");
            }//TypeAren-i het gorcoxutyunneri verj

            Console.ReadKey();
        }
    }
}