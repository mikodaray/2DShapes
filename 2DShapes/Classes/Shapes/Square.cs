using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DShapes.Classes.Shapes
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        private string name;

        public Rectangle(string name, double length, double width)
        {
            this.name = name;
            this.length = length;
            this.width = width;
        }

        public override ShapeType Type
        {
            get { return ShapeType.Rectangle; }
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

        private double GetPerimeter()
        {
            return 2 * (this.length + this.width);
        }

        private double GetSurfaceArea()
        {
            return (this.length + this.width);
        }

        /*
         * public methods
         */
        public bool isSquare()
        {
            return this.length == this.width;
        }
    }
}
