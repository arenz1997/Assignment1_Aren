using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesByAren
{
    public struct IntByAren
    {
        private int Num;

        public IntByAren(int num) { Num = num; }

        public int GetValue() { return Num; }
        public void SetValue(IntByAren A)
        {
            this.Num = A.Num;
        }
        public void SetValue(int A)
        {
            this.Num = A;
        }
        public override string ToString()
        {
            return Num.ToString();
        }
        //operatorneri overloading
        public static IntByAren operator +(IntByAren A, IntByAren B)
        {
            IntByAren C;
            C.Num = A.Num + B.Num;
            return C;
        }
        public static IntByAren operator +(IntByAren A, int B)
        {
            IntByAren C;
            C.Num = A.Num + B;
            return C;
        }
        public static IntByAren operator -(IntByAren A, IntByAren B)
        {
            IntByAren C;
            C.Num = A.Num - B.Num;
            return C;
        }
        public static IntByAren operator -(IntByAren A, int B)
        {
            IntByAren C;
            C.Num = A.Num - B;
            return C;
        }
        public static IntByAren operator *(IntByAren A, IntByAren B)
        {
            IntByAren C;
            C.Num = A.Num * B.Num;
            return C;
        }
        public static IntByAren operator *(IntByAren A, int B)
        {
            IntByAren C;
            C.Num = A.Num * B;
            return C;
        }
        public static IntByAren operator /(IntByAren A, IntByAren B)
        {
            IntByAren C;
            C.Num = A.Num / B.Num;
            return C;
        }
        public static IntByAren operator /(IntByAren A, int B)
        {
            IntByAren C;
            C.Num = A.Num / B;
            return C;
        }
        public static IntByAren operator %(IntByAren A, IntByAren B)
        {
            IntByAren C;
            C.Num = A.Num % B.Num;
            return C;
        }
        public static IntByAren operator %(IntByAren A, int B)
        {
            IntByAren C;
            C.Num = A.Num % B;
            return C;
        }
        public static IntByAren operator ++(IntByAren A)
        {
            A.Num++;
            return A;
        }
        public static IntByAren operator --(IntByAren A)
        {
            A.Num--;
            return A;
        }
        public static bool operator ==(IntByAren A, IntByAren B)
        {
            return A.Num == B.Num;
        }
        public static bool operator ==(IntByAren A, int B)
        {
            return A.Num == B;
        }
        public static bool operator !=(IntByAren A, IntByAren B)
        {
            return A.Num != B.Num;
        }
        public static bool operator !=(IntByAren A, int B)
        {
            return A.Num != B;
        }
        public static bool operator >(IntByAren A, IntByAren B)
        {
            return A.Num > B.Num;
        }
        public static bool operator >(IntByAren A, int B)
        {
            return A.Num > B;
        }
        public static bool operator <(IntByAren A, IntByAren B)
        {
            return A.Num < B.Num;
        }
        public static bool operator <(IntByAren A, int B)
        {
            return A.Num < B;
        }
        public static bool operator >=(IntByAren A, IntByAren B)
        {
            return A.Num >= B.Num;
        }
        public static bool operator >=(IntByAren A, int B)
        {
            return A.Num >= B;
        }
        public static bool operator <=(IntByAren A, IntByAren B)
        {
            return A.Num <= B.Num;
        }
        public static bool operator <=(IntByAren A, int B)
        {
            return A.Num <= B;
        }
        //operatorneri overloading
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
    public struct DoubleByAren
    {
        private double Num;

        public DoubleByAren(double num) { Num = num; }

        public double GetValue() { return Num; }
        public decimal GetDecimalValue() { decimal dec; dec = Convert.ToDecimal(Num); return dec; }
        public void SetValue(DoubleByAren A)
        {
            this.Num = A.Num;
        }
        public void SetValue(int A)
        {
            this.Num = A;
        }
        public void SetValue(double A)
        {
            this.Num = A;
        }
        public override string ToString()
        {
            return Num.ToString();
        }

        public static DoubleByAren operator +(DoubleByAren A, DoubleByAren B)
        {
            DoubleByAren C;
            C.Num = A.Num + B.Num;
            return C;
        }
        public static DoubleByAren operator +(DoubleByAren A, int B)
        {
            DoubleByAren C;
            C.Num = A.Num + Convert.ToDouble(B);
            return C;
        }
        public static DoubleByAren operator +(DoubleByAren A, double B)
        {
            DoubleByAren C;
            C.Num = A.Num + B;
            return C;
        }
        public static DoubleByAren operator -(DoubleByAren A, DoubleByAren B)
        {
            DoubleByAren C;
            C.Num = A.Num - B.Num;
            return C;
        }
        public static DoubleByAren operator -(DoubleByAren A, int B)
        {
            DoubleByAren C;
            C.Num = A.Num - Convert.ToDouble(B);
            return C;
        }
        public static DoubleByAren operator -(DoubleByAren A, double B)
        {
            DoubleByAren C;
            C.Num = A.Num - B;
            return C;
        }
        public static DoubleByAren operator *(DoubleByAren A, DoubleByAren B)
        {
            DoubleByAren C;
            C.Num = A.Num * B.Num;
            return C;
        }
        public static DoubleByAren operator *(DoubleByAren A, double B)
        {
            DoubleByAren C;
            C.Num = A.Num * B;
            return C;
        }
        public static DoubleByAren operator *(DoubleByAren A, int B)
        {
            DoubleByAren C;
            C.Num = A.Num * Convert.ToDouble(B);
            return C;
        }
        public static DoubleByAren operator /(DoubleByAren A, DoubleByAren B)
        {
            DoubleByAren C;
            C.Num = A.Num / B.Num;
            return C;
        }
        public static DoubleByAren operator /(DoubleByAren A, double B)
        {
            DoubleByAren C;
            C.Num = A.Num / B;
            return C;
        }
        public static DoubleByAren operator /(DoubleByAren A, int B)
        {
            DoubleByAren C;
            C.Num = A.Num / Convert.ToDouble(B);
            return C;
        }
        public static DoubleByAren operator %(DoubleByAren A, DoubleByAren B)
        {
            DoubleByAren C;
            C.Num = A.Num % B.Num;
            return C;
        }
        public static DoubleByAren operator %(DoubleByAren A, int B)
        {
            DoubleByAren C;
            C.Num = A.Num % Convert.ToDouble(B);
            return C;
        }
        public static DoubleByAren operator %(DoubleByAren A, double B)
        {
            DoubleByAren C;
            C.Num = A.Num % B;
            return C;
        }
        public static DoubleByAren operator ++(DoubleByAren A)
        {
            A.Num++;
            return A;
        }
        public static DoubleByAren operator --(DoubleByAren A)
        {
            A.Num--;
            return A;
        }
        public static bool operator ==(DoubleByAren A, DoubleByAren B)
        {
            return A.Num == B.Num;
        }
        public static bool operator !=(DoubleByAren A, DoubleByAren B)
        {
            return A.Num == B.Num;
        }
        public static bool operator ==(DoubleByAren A, double B)
        {
            return A.Num == B;
        }
        public static bool operator !=(DoubleByAren A, double B)
        {
            return A.Num == B;
        }
        public static bool operator ==(DoubleByAren A, int B)
        {
            return A.Num == Convert.ToDouble(B);
        }
        public static bool operator !=(DoubleByAren A, int B)
        {
            return A.Num == Convert.ToDouble(B);
        }
        public static bool operator >(DoubleByAren A, DoubleByAren B)
        {
            return A.Num > B.Num;
        }
        public static bool operator <(DoubleByAren A, DoubleByAren B)
        {
            return A.Num < B.Num;
        }
        public static bool operator >(DoubleByAren A, int B)
        {
            return A.Num > Convert.ToDouble(B);
        }
        public static bool operator <(DoubleByAren A, int B)
        {
            return A.Num < Convert.ToDouble(B);
        }
        public static bool operator >(DoubleByAren A, double B)
        {
            return A.Num > Convert.ToDouble(B);
        }
        public static bool operator <(DoubleByAren A, double B)
        {
            return A.Num < Convert.ToDouble(B);
        }
        public static bool operator >=(DoubleByAren A, DoubleByAren B)
        {
            return A.Num >= B.Num;
        }
        public static bool operator <=(DoubleByAren A, DoubleByAren B)
        {
            return A.Num <= B.Num;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}