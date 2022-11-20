using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class DepartmentsService
    {
        private readonly SalesWebMVCContext _context;
        public DepartmentsService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
