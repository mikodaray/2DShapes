FullName: Francis Mikhail T. Daray
Application: 2D shapes
Timebox: 2.5 Hours
Framework: C# -.NET 6.0


Assumptions: 
	1.) Create an object structure that would implement requirements for shapes written below.
	2.) It was not specified what the parameters are for every shape type so I decided to use radius for circle as shown in the example, and length and width for rectangle, which was not shown as an example.
	3.) Used simple abstract classes and implementation to achieve desired structure.
	4.) To appreciate my work I created a console application to utilize the new 2D Shapes library.

Improvements:
	1.) Being a simple implementation of basic 2D shapes, I think we can still add other properties to be derived from simple shapes, although Surface Area and Perimeter do seem like theyre the only properties for simple objects.
	2.) We can identify properties such as corners and angles along with their length, and include them in the design to implement Irregularly shaped 2D Objects.
	3.) Console Application might have a few issues as the timebox really limited me from testing it more.

Description:

# 2DShapes
Shapes sample app

- Hi, I am Francis Daray, created this C# project to implement 2D Shapes app.

The requirements for this project have been implemented and are as follows:

- All Shapes must have a Name, Perimeter, SurfaceArea.  
- For our initial demo, we need to have our implementation for a Circle and Rectangle.  
- Add an additional property for the Rectangle called "IsSquare" which should return true or false IsSquare = all sides are equal  
- Keep in mind that we will be adding more 2d shapes in the future. Useful Information: Shape Perimeter SurfaceArea Circle 2 * pi * r pi * r 2 Rectangle 2(l+w) wl pi = 3.14159


Implemented expected structure and methods in C#.

A .NET Console Application was also created to utilize the classes and methods and to showcase the 2D Shapes Library.

