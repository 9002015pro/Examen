using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
   public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Manufacturer { get; set; }
        public string Enable { get; set; }
        public int Price { get; set; }
        public Uri ImagePreview
        {
            get
            {
                var imageName = Environment.CurrentDirectory + (Image ?? "");
                return System.IO.File.Exists(imageName) ? new Uri(imageName) : null;
            }
        }
    }
}
