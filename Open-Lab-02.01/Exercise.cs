using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] pole = new double[] { 0.1, 1.1, 2.3, 3.4, 4.5 };
            return pole;

        }

        public double GetSecond(double[] numbers)
        {
            double[] a = Create5Numbers();
            return a[1];
        }
    }
}