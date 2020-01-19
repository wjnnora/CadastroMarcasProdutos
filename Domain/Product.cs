using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual int IdBrand { get; set; }
        public virtual string Name { get; set; }
        public virtual Brand ProductBrand{ get; set; }
    }
}
