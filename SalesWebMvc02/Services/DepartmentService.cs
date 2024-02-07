using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc02.Data;
using SalesWebMvc02.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc02.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc02Context _context;

        public DepartmentService(SalesWebMvc02Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async void Task<RemoveAsync>(int id)
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
           await _context.SaveChangesAsync();
        }
    }
}
