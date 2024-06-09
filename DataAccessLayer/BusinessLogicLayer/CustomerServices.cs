using DataAccessLayer.Entities;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
    
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
           return await _customerRepository.GetCustomers();
        }
    }
}
