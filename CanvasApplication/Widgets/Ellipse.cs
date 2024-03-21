using CanvasApplication.Abstractions;

namespace CanvasApplication.Widgets
{
    public class Ellipse : CyclicalWidgets, ISizeableWidget, IWidget
    {
        private decimal verticalAxis;
        private decimal horizontalAxis;
        public Ellipse(decimal axisARadius, decimal axisBRadius) : base(axisARadius, axisBRadius)
        {
            verticalAxis = axisARadius;
            horizontalAxis = axisBRadius;
        }
        private string name = "Ellipse";
        public string Name => name;

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public string Draw()
        {
            return $"{Name}: {GetSize().ToNDecimalPlaces(Constants.DecimalPlaces)}; " +
                    $"Horizontal Diameter {2 * horizontalAxis}, " +
                    $"Vertical Diameter: {2 * verticalAxis} " +
                    $"X: {XCoordinate}, Y: {YCoordinate}";

        }
    }
}
