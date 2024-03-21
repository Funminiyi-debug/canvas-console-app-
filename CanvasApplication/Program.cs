
using CanvasApplication;
using CanvasApplication.Widgets;

Canvas canvas = new Canvas();
var textBox = new TextBox(20, 50);

textBox.Text = "not empty";
textBox.XCoordinate = 80;
textBox.YCoordinate = 700;
textBox.BackgroundColor = "blue";

canvas.AddWidget(textBox);
canvas.DrawCanvas();
