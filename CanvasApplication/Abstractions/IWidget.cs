public interface IWidget
{
    public string Name { get; }
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }
    public string Draw();
}