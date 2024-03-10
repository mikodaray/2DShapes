using _2DShapes.Classes.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2DShapes.Classes
{
    public class Methods
    {
        public List<Shape> Shapes = new List<Shape>();

        public void ProgramStart()
        {
            Shapes = new List<Shape>();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome to 2D Shapes by Francis Daray!");
            Console.WriteLine("....");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("..");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("You may setup objects on this program by setting up the shape.");
            Console.WriteLine("After setting up, you may get useful information such as Perimeter and Surface Area");
            Console.WriteLine("..");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);

            string? strInput = "";
            bool input = true;

            Console.WriteLine("You may start by selecting which shape you would want to work on.");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);

            while (strInput?.ToLower() != "y")
            {
                Console.WriteLine("Would you like to start? (Y/N)");
                strInput = Console.ReadLine();

                if (strInput?.ToLower() == "y")
                {
                    Console.WriteLine("Lets start, shall we!");
                }
                else if (strInput?.ToLower() == "n")
                {
                    Console.WriteLine("Goodbye! :)");
                    return;
                }
            }

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Lets choose an option.");

                Console.WriteLine("*********************");
                Console.WriteLine("* 1 - Add Object    *");
                Console.WriteLine("* 2 - View Objects  *");
                Console.WriteLine("*********************");
                strInput = Console.ReadLine();

                if (strInput == "1")
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Lets choose a shape.");

                    Console.WriteLine("*********************");
                    Console.WriteLine("* 1 - Circle        *");
                    Console.WriteLine("* 2 - Rectangle     *");
                    Console.WriteLine("*********************");

                    strInput = Console.ReadLine();
                    string? objName = "";

                    if (strInput == "1")
                    {
                        double radius = 0.0;

                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("");

                        objName = "";

                        while ((objName == null ? "" : objName.ToString()).Length == 0)
                        {
                            Console.WriteLine("Can I have the name of the circle?");
                            strInput = Console.ReadLine();

                            if (Shapes.Where(s => s.Name == (objName == null ? "" : objName.ToString()).Trim()).Count() > 1)
                            {
                                Console.WriteLine("Name already exists try another one.");
                            }
                            else 
                            {
                                objName = strInput;
                            }
                        }

                        objName = strInput?.ToString();
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("");
                        Console.WriteLine("Can I have the radius of the circle?");

                        strInput = "";

                        while (!double.TryParse(strInput, out radius))
                        {
                            strInput = Console.ReadLine();

                            if (!double.TryParse(strInput, out radius))
                            {
                                Console.WriteLine("Not a number, try again.");
                            }
                        }

                        Shapes.Add(new Circle(objName == null ? "" : objName.ToString(), radius));

                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Added Circle - " + objName);
                    }
                    else if (strInput == "2")
                    {
                        double length = 0.0;
                        double width = 0.0;

                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("");
                        Console.WriteLine("Can I have the name of the rectangle?");
                        strInput = Console.ReadLine();
                        objName = strInput?.ToString();

                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("");
                        Console.WriteLine("Can I have the length of the rectangle?");

                        strInput = "";

                        while (!double.TryParse(strInput, out length))
                        {
                            strInput = Console.ReadLine();

                            if (!double.TryParse(strInput, out length))
                            {
                                Console.WriteLine("Not a number, try again.");
                            }
                        }

                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("");
                        Console.WriteLine("Can I have the width of the rectangle?");

                        strInput = "";

                        while (!double.TryParse(strInput, out width))
                        {
                            strInput = Console.ReadLine();

                            if (!double.TryParse(strInput, out width))
                            {
                                Console.WriteLine("Not a number, try again.");
                            }
                        }

                        Shapes.Add(new Rectangle(objName == null ? "" : objName.ToString(), length, width));

                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Added Rectangle - " + objName);
                    }
                }

                if (strInput == "2")
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Here are your objects.");
                    Console.WriteLine("");
                    Console.WriteLine("*********************");
                    foreach (Shape shape in Shapes)
                    {
                        int counter = 0;
                        if (shape.Type == ShapeType.Circle)
                        {
                            Console.WriteLine("* Name: " + counter++.ToString() + ") " + shape.Name + " - " + shape.Type.ToString());
                            Console.WriteLine("* Perimeter: " + shape.Perimeter);
                            Console.WriteLine("* Surface Area: " + shape.SurfaceArea);
                            Console.WriteLine("*********************");
                        }
                        else
                        {
                            Console.WriteLine("* Name: " + counter++.ToString() + " " + shape.Name + " - " + shape.Type.ToString());
                            Console.WriteLine("* Perimeter: " + shape.Perimeter);
                            Console.WriteLine("* Surface Area: " + shape.SurfaceArea);

                            string isSquare = ((Rectangle)shape).isSquare() ? "Yes" : "No";

                            Console.WriteLine("* Is Rectangle a square?: " + isSquare );
                            Console.WriteLine("*********************");
                        }
                    }
                    Console.WriteLine("*********************");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Press enter to go back.");
                    strInput = Console.ReadLine();
                }
            }

            return;

        }


    }
}
