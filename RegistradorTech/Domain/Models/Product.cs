using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistradorTech.Domain.Models
{
    public class Product
    {
        public string Name { get; set; }
        public long Quantity { get; set; }
        public DateTime Date{ get; set; }
        public long Cost { get; set; }
        public Supplier Fornecedor{ get; set; }
        public Responsible Responsavel { get; set; }

    }
}
