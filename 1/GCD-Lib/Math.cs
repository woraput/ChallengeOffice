using System;
namespace CalulateMathLib
{
    public class CalulateMath
    {
        public int CalulateGCD(int a, int b)
        {
            if (b == 0) return a;
            var c = a % b;
            if (c == 0 && a != 0) return b;
            else
            {
                while (c != 0)
                {
                    a = b;
                    b = c;
                    c = a % b;
                }
                return b;
            }
        }
        public int CalulateLCM(int a, int b)
        {
            var calGCD = CalulateGCD(a, b);
            var calLCM = (a * b) / calGCD;
            return calLCM;
        }
    }
}
