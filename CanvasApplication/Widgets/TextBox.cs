namespace CanvasApplication.Widgets
{
    public class TextBox : Rectangle, IWidget
    {
        public TextBox(decimal height, decimal width) : base(height, width)
        {
            _text = string.Empty;
            _backgroundColor = "Red";
        }
        private string _text;
        private string _backgroundColor;

        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
            }
        }
        public string Text
        {
            get { return _text; }
            set
            {
                if (value == string.Empty || value == null)
                {
                    _backgroundColor = "Red";
                }
                _text = value;
            }
        }

        public new string Draw()
        {
            return base.Draw() +
                $" Background: {BackgroundColor};" +
                $" Text: {Text}";

        }
    }
}
