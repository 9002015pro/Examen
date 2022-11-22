using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMyself.Model
{
    public class Manufacturers
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return Title;
        }

    }
}
