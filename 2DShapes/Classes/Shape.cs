using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2DShapes.Classes
{
    public enum ShapeType
    {
        Rectangle = 1,
        Circle = 2
    }

    abstract public class Shape
    {
        protected Shape() 
        { 
        }
        public abstract ShapeType Type { get; }

        public abstract string Name { get; set; }

        public abstract double Perimeter { get; }

        public abstract double SurfaceArea { get; }

    }
}
