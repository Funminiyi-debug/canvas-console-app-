namespace CanvasApplication.Abstractions
{
    public abstract class CyclicalWidgets : ISizeableWidget
    {
        private decimal VerticalRadius { get; }
        private decimal HorizontalRadius { get; }

        public CyclicalWidgets(decimal verticalRadius, decimal horizontalRadius)
        {
            if (verticalRadius < 0 || horizontalRadius < 0) { throw new Exception("horizontal or vertical radius cannot be non-negative"); }
            VerticalRadius = verticalRadius;
            HorizontalRadius = horizontalRadius;
        }

        public virtual decimal GetSize()
        {
            return VerticalRadius * HorizontalRadius * Convert.ToDecimal(Math.PI);
        }
    }
}
