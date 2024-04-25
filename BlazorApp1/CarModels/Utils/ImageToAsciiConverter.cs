using System.Drawing;
using System.Text;

namespace BlazorApp1.CarModels.Utils
{
        public class ImageToAsciiConverter : IImageToAsciiConverter
        {
            public string ConvertImageToAscii(Stream imageStream)
            {
                using var image = Image.FromStream(imageStream);
                using var resizedImage = ResizeImage(image, 100, 50); // Resize for ASCII art
                return ConvertToAscii(resizedImage);
            }

            private Bitmap ResizeImage(Image image, int width, int height)
            {
                var resizedImage = new Bitmap(width, height);
                using (var graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.DrawImage(image, 0, 0, width, height);
                }
                return resizedImage;
            }

            private string ConvertToAscii(Bitmap image)
            {
                var asciiArt = new StringBuilder();

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        var pixelColor = image.GetPixel(x, y);
                        var grayValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        var asciiChar = GetAsciiChar(grayValue);
                        asciiArt.Append(asciiChar);
                    }
                    asciiArt.AppendLine();
                }

                return asciiArt.ToString();
            }

            private char GetAsciiChar(int grayValue)
            {
                // ASCII characters sorted by visual weight
                const string asciiChars = "@%#*+=-:. ";
                var index = grayValue * (asciiChars.Length - 1) / 255;
                return asciiChars[index];
            }
        }                                                                                                            
}
