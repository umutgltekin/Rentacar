using Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public  class Product:IEntity
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public int CategoryId { get; set; }
        public short UnitInstock { get; set; }
        public int UnitPrice { get; set; }
    }
}
