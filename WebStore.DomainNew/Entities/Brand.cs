using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.DomainNew.Entities.Base.Interfaces;
using WebStore.DomainNew.Entities.Base;

namespace WebStore.DomainNew.Entities
{
    [Table("Brands")]
    public class Brand:NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
