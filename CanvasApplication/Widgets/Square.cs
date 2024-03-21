using CanvasApplication.Abstractions;

namespace CanvasApplication.Widgets
{
    public class Square : BoxyWidgets, IWidget, ISizeableWidget
    {

        public Square(decimal height, decimal width) : base(height, width)
        {
            if (height != width)
            {
                throw new Exception("Square height and width should be the same.");
            }
        }

        private string name = "Square";
        public int XCoordinate { get; set; } = 0;
        public int YCoordinate { get; set; } = 0;

        public string Name { get { return name; } }

        public string Draw()
        {
            return $"{Name}: {GetSize().ToNDecimalPlaces(Constants.DecimalPlaces)}; X: {XCoordinate}, Y: {YCoordinate}";
        }
    }
}
