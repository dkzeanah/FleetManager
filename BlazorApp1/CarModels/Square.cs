namespace BlazorApp1.CarModels
{
    public class Square
    {
        public Guid Id { get; set; }
        public string? content { get; set; }
        public string Color { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }

    // Inside your component...
    // private List<Square> Squares { get; set; } = new List<Square>();

}
