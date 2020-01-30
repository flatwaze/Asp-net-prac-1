using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class WarehouseView:BasicObjectView
    {
        public string Location { get; set; }
        public int Size { get; set; }
    }
}
