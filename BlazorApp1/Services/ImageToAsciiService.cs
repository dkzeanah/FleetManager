using BlazorApp1.CarModels.Utils;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class ImageToAsciiService : IImageToAsciiService
    {
        private readonly IImageToAsciiConverter converter;

        public ImageToAsciiService(IImageToAsciiConverter converter)
        {
            this.converter = converter;
        }

        public string ConvertImage(Stream imageStream)
        {
            return converter.ConvertImageToAscii(imageStream);
        }
    }
}
