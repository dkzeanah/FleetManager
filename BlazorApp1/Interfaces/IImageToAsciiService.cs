namespace BlazorApp1.Interfaces
{
    public interface IImageToAsciiService
    {
        string ConvertImage(Stream imageStream);
    }
}
