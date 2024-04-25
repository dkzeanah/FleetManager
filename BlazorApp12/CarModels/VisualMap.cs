namespace BlazorApp1.CarModels
{
    public class VisualMap
    {
        public List<Coordinate> Coordinates { get; set; }

        // Method to add a coordinate to the map.
        public void AddCoordinate(Coordinate coordinate)
        {
            Coordinates.Add(coordinate);
        }

        // You may need methods to retrieve or manipulate the coordinates,
        // depending on how you plan to use this class.
    }
}
