using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class AdoNetProductDal
    {
        public void Add(Product product)
        {
            Console.WriteLine("Adonet ile ürün eklendi.");
        }
    }
}
