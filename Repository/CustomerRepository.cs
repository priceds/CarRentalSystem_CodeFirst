using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CarRentalDbContext _context;
        public CustomerRepository(CarRentalDbContext context)
        {
            _context = context;
        }
        public int AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return 1;
        }

        public async Task<Customer> CheckIfCustomerIsValid(string email, string password)
        {
            return await _context.Customers.Where(customer => customer.CustomerEmail == email && customer.CustomerPassword == password).SingleOrDefaultAsync();
        }

        public int DeleteCustomer(int id)
        {
            var CustomerInDb = _context.Customers.Where(customer => customer.CustomerId == id).SingleOrDefault();
            _context.Customers.Remove(CustomerInDb);
            _context.SaveChanges();
            return 1;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomer(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<Customer> GetCustomersWhoRActive()
        {
            var listOfActiveCustomers = await _context.Customers.Where(customer => customer.IsActive == "Yes").SingleOrDefaultAsync();

            return listOfActiveCustomers;
        }

        public int UpdateCustomer(Customer customer)
        {
            var CustomerInDb = _context.Customers.Where(customer => customer.CustomerId == customer.CustomerId).SingleOrDefault();

            CustomerInDb.CustomerName = customer.CustomerName;
            CustomerInDb.CustomerPassword = customer.CustomerPassword;
            CustomerInDb.CustomerPhone = customer.CustomerPhone;
            CustomerInDb.CustomerEmail = customer.CustomerEmail;
            CustomerInDb.CustomerPin = customer.CustomerPin;
            _context.SaveChanges();
            return 1;

        }
    }
}
