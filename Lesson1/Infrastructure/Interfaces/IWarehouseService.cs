using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;


namespace WebStore.Infrastructure.Interfaces
{
    public interface IWarehouseService:IObjectService
    {
        WarehouseView GetById(int id);
        IEnumerable<WarehouseView> GetAll();

        void Add(WarehouseView model);
    }
}
