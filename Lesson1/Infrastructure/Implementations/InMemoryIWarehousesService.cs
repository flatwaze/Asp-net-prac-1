using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Implementations
{
    public class InMemoryIWarehousesService:IWarehouseService
    {
        private readonly List<WarehouseView> _warehouses;
        public InMemoryIWarehousesService()
        {
            _warehouses = new List<WarehouseView>() {
            new WarehouseView {Id = 1, Name = "Best", Location = "SW", Size = 400},
            new WarehouseView {Id = 2, Name = "T", Location = "W", Size = 200}
        };
        }

        public IEnumerable<WarehouseView> GetAll()
        {
            return _warehouses;
        }

        public WarehouseView GetById(int id)
        {
            return _warehouses.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Commit()
        {
        }

        public void Add(WarehouseView model)
        {
            model.Id = _warehouses.Max(x => x.Id) + 1;
            _warehouses.Add(model);
        }

        public void Delete(int id)
        {
            WarehouseView warehouse = GetById(id);
            if (warehouse != null)
                _warehouses.Remove(warehouse);
        }

    }
}
