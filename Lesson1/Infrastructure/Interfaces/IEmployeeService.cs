using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IEmployeeService:IObjectService
    {
        EmployeeView GetById(int id);
        IEnumerable<EmployeeView> GetAll();

        void Add(EmployeeView model);
    }
}
