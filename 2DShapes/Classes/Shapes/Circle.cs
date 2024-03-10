using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2DShapes.Classes.Shapes
{

    public class Circle : Shape
    {
        private double Radius;
        private string name;

        public Circle(string name, double radius)
        {
            this.name = name;
            this.Radius = radius;
        }

        public override ShapeType Type
        {
            get { return ShapeType.Circle; }
        }

        public override string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override double Perimeter
        { 
            get { return GetPerimeter(); }
        }

        public override double SurfaceArea
        {
            get { return GetSurfaceArea(); }
        }

        public double GetPerimeter() 
        {
            return 2 * Math.PI * this.Radius;
        }

        public double GetSurfaceArea()
        {
            return 2 * Math.PI * (Math.Pow(this.Radius,2));
        }

    }
}
