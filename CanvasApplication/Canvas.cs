namespace CanvasApplication
{
    public class Canvas
    {
        IList<IWidget> widgets = new List<IWidget>();
        public void AddWidget(IWidget widget)
        {
            widgets.Add(widget);
        }

        public void RemoveWidget(IWidget widget)
        {
            widgets.Remove(widget);
        }

        public int GetWidgetCount()
        {
            return widgets.Count();
        }

        public void DrawCanvas()
        {
            foreach (IWidget widget in widgets)
            {
                Console.WriteLine(widget.Draw());
            }
        }
    }
}
