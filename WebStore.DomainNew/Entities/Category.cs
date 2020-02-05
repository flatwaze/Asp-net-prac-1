using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.DomainNew.Entities.Base.Interfaces;
using WebStore.DomainNew.Entities.Base;

namespace WebStore.DomainNew.Entities
{
    [Table("Categories")]
    public class Category : NamedEntity, IOrderedEntity
    {
        public int? ParentId { get; set; }
        public int Order { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }
     }
}
