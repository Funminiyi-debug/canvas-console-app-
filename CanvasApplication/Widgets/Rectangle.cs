using CanvasApplication.Abstractions;

namespace CanvasApplication.Widgets
{
    public class Rectangle : BoxyWidgets, IWidget, ISizeableWidget
    {

        public Rectangle(decimal height, decimal width) : base(height, width)
        {

        }

        private string name = "Rectangle";
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public string Name { get { return name; } }

        public string Draw()
        {
            return $"{Name}: {GetSize().ToNDecimalPlaces(Constants.DecimalPlaces)}; X: {XCoordinate}, Y: {YCoordinate}";
        }
    }
}
