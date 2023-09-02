using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;


        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Side/Sides lower/equal then zero");
            this.a = a;
            this.b = b;
            this.c = c;

        }


        public override double GetSquare()
        {//Проверка на прямоугольность треугольника
            double hyp = 0;
            double k1 = 0;
            double k2 = 0;
            if (a > b && a > c)
            {
                hyp = a;
                k1 = b;
                k2 = c;
            }
            else if (b > a && b > c)
            {
                hyp = b;
                k1 = a;
                k2 = c;
            }
            else if (c > a && c > b)
            {
                hyp = c;
                k1 = a;
                k2 = b;
            }
            if ((k1 != 0) && (k1 * k1 + k2 * k2 == hyp * hyp))
                return k1 * k2 / 2;


            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }
    }
}