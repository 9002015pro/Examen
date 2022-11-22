using DriveMyself.Model;
using examen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMyself.Classes
{
    interface IDataProvider
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Manufacturers> GetManufacturers();
        void SaveProducts(Product current);
    }
}
