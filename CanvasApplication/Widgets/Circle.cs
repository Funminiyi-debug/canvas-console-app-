using CanvasApplication.Abstractions;

namespace CanvasApplication.Widgets
{
    public class Circle : CyclicalWidgets, ISizeableWidget, IWidget
    {
        public Circle(decimal radius) : base(radius, radius)
        {

        }
        private string name = "Circle";
        public string Name => name;

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public string Draw()
        {
            return $"{Name}: {GetSize().ToNDecimalPlaces(Constants.DecimalPlaces)}; X: {XCoordinate}, Y: {YCoordinate}";
        }
    }
}
