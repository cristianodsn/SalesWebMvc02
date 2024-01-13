using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc02.Data;
using SalesWebMvc02.Models;

namespace SalesWebMvc02.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc02Context _context;

        public DepartmentService(SalesWebMvc02Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
