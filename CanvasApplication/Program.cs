
using CanvasApplication;
using CanvasApplication.Widgets;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();
Constants.InitializeFromConfiguration(configuration);


Canvas canvas = new Canvas();
var textBox = new TextBox(20, 50);

textBox.Text = "not empty";
textBox.XCoordinate = 80;
textBox.YCoordinate = 700;
textBox.BackgroundColor = "blue";

canvas.AddWidget(textBox);
var ellipse = new Ellipse(10, 30);

ellipse.XCoordinate = 400;
ellipse.YCoordinate = 600;

canvas.AddWidget(ellipse);

canvas.DrawCanvas();
