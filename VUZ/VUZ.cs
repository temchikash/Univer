using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUZ
{
    public class VUZ
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string City {get; set;}
        public byte[] Photo {get; set;}
        public VUZ()
        {

        }
        public VUZ(int id, string name, string city, byte[] photo)
        {
            Id = id;
            Name = name;
            City = city;
            Photo = photo;
        }
        public VUZ(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }
        static public Image ByteArrToPicture(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        static public byte[] PictureToByteArr(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
