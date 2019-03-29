using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    public struct CustomInt
    {
        private int Num;
        
        public CustomInt(int num) { Num = num; }

        public int GetValue() { return Num; }
        public void SetValue(CustomInt A)
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
        //Overloading operators
        public static CustomInt operator +(CustomInt A, CustomInt B)
        {
            CustomInt C;
            C.Num = A.Num + B.Num;
            return C;
        }
        public static CustomInt operator +(CustomInt A, int B)
        {
            CustomInt C;
            C.Num = A.Num + B;
            return C;
        }
        public static CustomInt operator -(CustomInt A, CustomInt B)
        {
            CustomInt C;
            C.Num = A.Num - B.Num;
            return C;
        }
        public static CustomInt operator -(CustomInt A, int B)
        {
            CustomInt C;
            C.Num = A.Num - B;
            return C;
        }
        public static CustomInt operator *(CustomInt A, CustomInt B)
        {
            CustomInt C;
            C.Num = A.Num * B.Num;
            return C;
        }
        public static CustomInt operator *(CustomInt A, int B)
        {
            CustomInt C;
            C.Num = A.Num * B;
            return C;
        }
        public static CustomInt operator /(CustomInt A, CustomInt B)
        {
            CustomInt C;
            C.Num = A.Num / B.Num;
            return C;
        }
        public static CustomInt operator /(CustomInt A, int B)
        {
            CustomInt C;
            C.Num = A.Num / B;
            return C;
        }
        public static CustomInt operator %(CustomInt A, CustomInt B)
        {
            CustomInt C;
            C.Num = A.Num % B.Num;
            return C;
        }
        public static CustomInt operator %(CustomInt A, int B)
        {
            CustomInt C;
            C.Num = A.Num % B;
            return C;
        }
        public static CustomInt operator ++(CustomInt A)
        {
            A.Num++;
            return A;
        }
        public static CustomInt operator --(CustomInt A)
        {
            A.Num--;
            return A;
        }
        public static bool operator ==(CustomInt A, CustomInt B)
        {
            return A.Num == B.Num;
        }
        public static bool operator ==(CustomInt A, int B)
        {
            return A.Num == B;
        }
        public static bool operator !=(CustomInt A, CustomInt B)
        {
            return A.Num != B.Num;
        }
        public static bool operator !=(CustomInt A, int B)
        {
            return A.Num != B;
        }
        public static bool operator >(CustomInt A, CustomInt B)
        {
            return A.Num > B.Num;
        }
        public static bool operator >(CustomInt A, int B)
        {
            return A.Num > B;
        }
        public static bool operator <(CustomInt A, CustomInt B)
        {
            return A.Num < B.Num;
        }
        public static bool operator <(CustomInt A, int B)
        {
            return A.Num < B;
        }
        public static bool operator >=(CustomInt A, CustomInt B)
        {
            return A.Num >= B.Num;
        }
        public static bool operator >=(CustomInt A, int B)
        {
            return A.Num >= B;
        }
        public static bool operator <=(CustomInt A, CustomInt B)
        {
            return A.Num <= B.Num;
        }
        public static bool operator <=(CustomInt A, int B)
        {
            return A.Num <= B;
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
    
    public struct CustomDouble
    {
        private double Num;

        public CustomDouble(double num) { Num = num; }

        public double GetValue() { return Num; }
        public decimal GetDecimalValue() { decimal dec; dec = Convert.ToDecimal(Num); return dec; }
        public void SetValue(CustomDouble A)
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

        public static CustomDouble operator +(CustomDouble A, CustomDouble B)
        {
            CustomDouble C;
            C.Num = A.Num + B.Num;
            return C;
        }
        public static CustomDouble operator +(CustomDouble A, int B)
        {
            CustomDouble C;
            C.Num = A.Num + Convert.ToDouble(B);
            return C;
        }
        public static CustomDouble operator +(CustomDouble A, double B)
        {
            CustomDouble C;
            C.Num = A.Num + B;
            return C;
        }
        public static CustomDouble operator -(CustomDouble A, CustomDouble B)
        {
            CustomDouble C;
            C.Num = A.Num - B.Num;
            return C;
        }
        public static CustomDouble operator -(CustomDouble A, int B)
        {
            CustomDouble C;
            C.Num = A.Num - Convert.ToDouble(B);
            return C;
        }
        public static CustomDouble operator -(CustomDouble A, double B)
        {
            CustomDouble C;
            C.Num = A.Num - B;
            return C;
        }
        public static CustomDouble operator *(CustomDouble A, CustomDouble B)
        {
            CustomDouble C;
            C.Num = A.Num * B.Num;
            return C;
        }
        public static CustomDouble operator *(CustomDouble A, double B)
        {
            CustomDouble C;
            C.Num = A.Num * B;
            return C;
        }
        public static CustomDouble operator *(CustomDouble A, int B)
        {
            CustomDouble C;
            C.Num = A.Num * Convert.ToDouble(B);
            return C;
        }
        public static CustomDouble operator /(CustomDouble A, CustomDouble B)
        {
            CustomDouble C;
            C.Num = A.Num / B.Num;
            return C;
        }
        public static CustomDouble operator /(CustomDouble A, double B)
        {
            CustomDouble C;
            C.Num = A.Num / B;
            return C;
        }
        public static CustomDouble operator /(CustomDouble A, int B)
        {
            CustomDouble C;
            C.Num = A.Num / Convert.ToDouble(B);
            return C;
        }
        public static CustomDouble operator %(CustomDouble A, CustomDouble B)
        {
            CustomDouble C;
            C.Num = A.Num % B.Num;
            return C;
        }
        public static CustomDouble operator %(CustomDouble A, int B)
        {
            CustomDouble C;
            C.Num = A.Num % Convert.ToDouble(B);
            return C;
        }
        public static CustomDouble operator %(CustomDouble A, double B)
        {
            CustomDouble C;
            C.Num = A.Num % B;
            return C;
        }
        public static CustomDouble operator ++(CustomDouble A)
        {
            A.Num++;
            return A;
        }
        public static CustomDouble operator --(CustomDouble A)
        {
            A.Num--;
            return A;
        }
        public static bool operator ==(CustomDouble A, CustomDouble B)
        {
            return A.Num == B.Num;
        }
        public static bool operator !=(CustomDouble A, CustomDouble B)
        {
            return A.Num == B.Num;
        }
        public static bool operator ==(CustomDouble A, double B)
        {
            return A.Num == B;
        }
        public static bool operator !=(CustomDouble A, double B)
        {
            return A.Num == B;
        }
        public static bool operator ==(CustomDouble A, int B)
        {
            return A.Num == Convert.ToDouble(B);
        }
        public static bool operator !=(CustomDouble A, int B)
        {
            return A.Num == Convert.ToDouble(B);
        }
        public static bool operator >(CustomDouble A, CustomDouble B)
        {
            return A.Num > B.Num;
        }
        public static bool operator <(CustomDouble A, CustomDouble B)
        {
            return A.Num < B.Num;
        }
        public static bool operator >(CustomDouble A, int B)
        {
            return A.Num > Convert.ToDouble(B);
        }
        public static bool operator <(CustomDouble A, int B)
        {
            return A.Num < Convert.ToDouble(B);
        }
        public static bool operator >(CustomDouble A, double B)
        {
            return A.Num > Convert.ToDouble(B);
        }
        public static bool operator <(CustomDouble A, double B)
        {
            return A.Num < Convert.ToDouble(B);
        }
        public static bool operator >=(CustomDouble A, CustomDouble B)
        {
            return A.Num >= B.Num;
        }
        public static bool operator <=(CustomDouble A, CustomDouble B)
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