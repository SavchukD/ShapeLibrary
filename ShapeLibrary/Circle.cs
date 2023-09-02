using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Circle : Shape
    {

        private double radius;

        public Circle(float radius)
        {
            if (radius < 0)
                throw new Exception("Radius lower then zero");
            this.radius = radius;
        }



        public override double GetSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}
