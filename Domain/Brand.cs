using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Brand
    {
        public virtual int Id { get; set; }       
        public virtual string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
