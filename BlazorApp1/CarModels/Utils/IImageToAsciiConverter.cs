namespace BlazorApp1.CarModels.Utils
{
    public interface IImageToAsciiConverter
    {
        string ConvertImageToAscii(Stream imageStream);

    }
}
