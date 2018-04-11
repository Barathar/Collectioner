using System;
using System.Drawing;
using System.IO;

namespace HomeCollection.Utility
{
    public class Base64Converter
    {
        public static string ImageToString(Image image)
        {          
            MemoryStream stream = new MemoryStream();

            image.Save(stream, image.RawFormat);
            byte[] array = stream.ToArray();
            return Convert.ToBase64String(array);
        }

        public static Image StringToImage(string base64)
        {
            if (string.IsNullOrWhiteSpace(base64))
                throw new ArgumentNullException("base64");

            byte[] array = Convert.FromBase64String(base64);
            Image image = Image.FromStream(new MemoryStream(array));
            return image;
        }
    }
}
