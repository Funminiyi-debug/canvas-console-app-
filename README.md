<strong>Simple Drawing Application</strong>

This project is a C# Console Application that simulates a simple drawing environment. It allows the creation and manipulation of various geometric widgets such as squares, rectangles, circles, ellipses, and text boxes on a virtual canvas. The application outputs textual representations of these widgets, showcasing their properties and dimensions.

<strong>Features</strong>

Canvas: A virtual space where widgets are placed and rendered.

Widgets: Diverse shapes including squares, rectangles, circles, ellipses, and text boxes, each with unique properties.

Extensible Architecture: Easily extendable with more widget types or functionalities.

<strong>Getting Started</strong>

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

Prerequisites
.NET 5.0 or higher
Visual Studio 2022 or any preferred IDE that supports C# development
Installation
Clone the repository or download the ZIP file of the project.
Open the solution file CanvasApplication.sln in Visual Studio or your preferred IDE.
Build the solution to restore the NuGet packages and compile the project.
Run the application.
Usage
The application is a console application and does not have a graphical user interface. Once you run the application, it will execute the predefined demo in Program.cs, which demonstrates the creation of various widgets and their placement on the canvas.

To customize the widgets and their properties, modify the Program.cs file with different shapes and parameters.

Example:

`Canvas canvas = new Canvas();`
<br />
<code> var square = new Square(20, 20); // Creates a square widget<br />
square.XCoordinate = 20;
square.YCoordinate = 30;

canvas.AddWidget(square);<br />
canvas.DrawCanvas(); // Renders the canvas with the square </code>
