namespace CanvasApplication.Abstractions
{
    public abstract class BoxyWidgets : ISizeableWidget
    {
        private decimal Height { get; }
        private decimal Width { get; }

        public BoxyWidgets(decimal height, decimal width)
        {
            if (height < 0 || width < 0) throw new Exception("height or width cannot be non-negative");
            Height = height;
            Width = width;
        }

        public virtual decimal GetSize()
        {
            return Height * Width;
        }
    }
}
