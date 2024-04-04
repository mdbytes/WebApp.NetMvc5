using DataObjectLayer;
using DataAccessInterface;
using LogicLayerInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace LogicLayer
{
    public class CustomerManager : ICustomerManager
    {

        private ICustomerAccess customerAccess;

        public CustomerManager() 
        {
            customerAccess = new CustomerAccess();
        }


        public bool AddCustomer(CustomerVM customer)
        {
            return customerAccess.AddCustomer(customer);
        }

        public bool DeleteCustomer(int id)
        {
            return customerAccess.DeleteCustomer(id);
        }

        public CustomerVM GetCustomerById(int id)
        {
            return customerAccess.GetCustomerById(id);
        }

        public List<CustomerVM> GetCustomers()
        {
            return customerAccess.GetCustomers();
        }

        public bool UpdateCustomer(CustomerVM customer)
        {
            return customerAccess.UpdateCustomer(customer);
        }
    }
}
