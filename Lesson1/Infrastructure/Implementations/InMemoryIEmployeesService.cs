using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrastructure.Implementations
{
    public class InMemoryIEmployeesService : IEmployeeService
    {
        private readonly List<EmployeeView> _employees;

        public InMemoryIEmployeesService()
        {
            _employees = new List<EmployeeView>
            {
                new EmployeeView
                {
                    Id = 1,
                    Name = "Кеша",
                    Surname = "Васин",
                    Age = 67
                },

                new EmployeeView
                {
                    Id = 2,
                    Name = "Терентий",
                    Surname = "Петров",
                    Age = 24
                }
            };
        }

        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }

        public EmployeeView GetById(int id)
        {
            return _employees.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Commit()
        {
        }

        public void Add(EmployeeView model)
        {
            model.Id = _employees.Max(x => x.Id) + 1;
            _employees.Add(model);
        }

        public void Delete(int id)
        {
            EmployeeView employee = GetById(id);
            if (employee != null)
                _employees.Remove(employee);
        }

    }
}
