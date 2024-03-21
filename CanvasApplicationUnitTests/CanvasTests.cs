using CanvasApplication;
using CanvasApplication.Widgets;

namespace CanvasApplicationUnitTests
{
    public class CanvasTests
    {

        private StringWriter consoleOutput;
        private TextWriter originalConsoleOut;

        public CanvasTests()
        {
            consoleOutput = new StringWriter();
            originalConsoleOut = Console.Out;
            Console.SetOut(consoleOutput);
        }

        private void TearDown()
        {
            Console.SetOut(originalConsoleOut);
            consoleOutput.Dispose();
        }
        [Fact]
        public void AddingWidget_ShouldIncreaseWidgetsCount()
        {
            decimal height = 30;
            decimal width = 40;

            int x = 20;
            int y = 40;

            decimal radius = 10;

            Canvas canvas = new Canvas();
            var square = new Square(height, width);
            square.XCoordinate = x;
            square.YCoordinate = y;

            canvas.AddWidget(square);

            var circle = new Circle(radius);
            circle.XCoordinate = x + 2;
            circle.YCoordinate = y + 2;

            canvas.AddWidget(circle);
            canvas.DrawCanvas();

            Assert.Equal(2, canvas.GetWidgetCount());
        }

        [Fact]
        public void Canvas_ShouldContainAllWidgetDrawOutputs_WhenMultipleWidgetsAdded()
        {
            decimal height = 30;
            decimal width = 40;

            int x = 20;
            int y = 40;

            var expectedSquareOutput = $"Square: 1200.000; X: {x}, Y: {y}";
            var expectedCircleOutput = $"Circle: 314.159; X: {x + 2}, Y: {y + 2}";


            decimal radius = 10;

            Canvas canvas = new Canvas();
            var square = new Square(height, width);
            square.XCoordinate = x;
            square.YCoordinate = y;

            canvas.AddWidget(square);

            var circle = new Circle(radius);
            circle.XCoordinate = x + 2;
            circle.YCoordinate = y + 2;

            canvas.AddWidget(circle);
            canvas.DrawCanvas();

            Assert.Contains(expectedSquareOutput, consoleOutput.ToString());
            Assert.Contains(expectedCircleOutput, consoleOutput.ToString());
            TearDown();
        }

        [Fact]
        public void TextBox_Draw_IncludesTextContentInOutput()
        {
            // Arrange
            decimal height = 30;
            decimal width = 40;
            var textBox = new TextBox(height, width);
            var expectedTextContent = "Hello, World!";
            textBox.Text = expectedTextContent;

            // Act
            var output = textBox.Draw();

            // Assert
            Assert.Contains(expectedTextContent, output);
        }

        [Fact]
        public void DrawCanvas_WithOneSquare_ShouldReturnCorrectString()
        {
            decimal height = 30;
            decimal width = 30;

            int x = 20;
            int y = 40;
            var expectedString = $"Square: 900.000; X: {x}, Y: {y}";

            Canvas canvas = new Canvas();
            var square = new Square(height, width);
            square.XCoordinate = x;
            square.YCoordinate = y;

            canvas.AddWidget(square);

            Assert.Equal(expectedString, square.Draw());
        }

        [Fact]
        public void DrawCanvas_WithOneRectangle_ShouldReturnCorrectString()
        {
            decimal height = 30;
            decimal width = 40;

            int x = 20;
            int y = 40;
            var expectedString = $"Rectangle: 1200.000; X: {x}, Y: {y}";

            Canvas canvas = new Canvas();
            var rectangle = new Rectangle(height, width);
            rectangle.XCoordinate = x;
            rectangle.YCoordinate = y;

            canvas.AddWidget(rectangle);

            Assert.Equal(expectedString, rectangle.Draw());
        }

        [Fact]
        public void Draw_WithOneCircle_ShouldReturnCorrectString()
        {
            decimal radius = 10;


            int x = 20;
            int y = 40;
            var expectedString = $"Circle: 314.159; X: {x}, Y: {y}";

            var circle = new Circle(radius);
            circle.XCoordinate = x;
            circle.YCoordinate = y;

            Assert.Equal(expectedString, circle.Draw());
        }

        [Fact]
        public void Square_Creation_WithValidParameters_ShouldSetPropertiesCorrectly()
        {
            decimal height = 30;
            decimal width = 30;

            int x = 20;
            int y = 40;

            Canvas canvas = new Canvas();
            var square = new Square(height, width);
            square.XCoordinate = x;
            square.YCoordinate = y;

            Assert.Equal("Square", square.Name);
            Assert.Equal(20, square.XCoordinate);
            Assert.Equal(40, square.YCoordinate);
            Assert.Equal(900, square.GetSize());
        }

        [Fact]
        public void SettingTextToEmptyString_ShouldSetBackgroundColorToRed()
        {
            Canvas canvas = new Canvas();
            var textBox = new TextBox(20, 50);

            textBox.Text = "not empty";
            textBox.XCoordinate = 80;
            textBox.YCoordinate = 700;
            textBox.BackgroundColor = "blue";
            textBox.Text = "";

            canvas.AddWidget(textBox);
            canvas.DrawCanvas();

            Assert.Equal("Red", textBox.BackgroundColor);
        }

        [Fact]
        public void DrawCanvas_WithOneEllipse_ShouldReturnCorrectString()
        {
            decimal radiusVertical = 10;
            decimal radiusHorizontal = 20;

            Canvas canvas = new Canvas();

            int x = 20;
            int y = 40;
            var expectedString = $"Ellipse: 628.319";

            var ellipse = new Ellipse(radiusVertical, radiusHorizontal);
            ellipse.XCoordinate = x;
            ellipse.YCoordinate = y;

            canvas.AddWidget(ellipse);

            canvas.DrawCanvas();

            Assert.Contains(expectedString, consoleOutput.ToString());
        }

    }
}