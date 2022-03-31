using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly CarRentalDbContext _context;
        public AdminRepository(CarRentalDbContext context)
        {
            _context = context;
        }
        public async Task<Admin> CheckIfAdminisValid(string email, string password)
        {
            return await _context.Admins.Where(admin => admin.AdminEmail == email && admin.AdminPassword == password).SingleOrDefaultAsync();
        }
    }
}
