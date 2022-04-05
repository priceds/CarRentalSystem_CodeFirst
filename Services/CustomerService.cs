using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public int AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public Task<Customer> CheckIfCustomerIsValid(string email, string password)
        {
            return _customerRepository.CheckIfCustomerIsValid(email, password);
        }

        public int DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

        public Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();

        }

        public Task<Customer> GetCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }

        public Task<Customer> GetCustomersWhoRActive()
        {
            return _customerRepository.GetCustomersWhoRActive();
        }

        public int UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
    }
}
