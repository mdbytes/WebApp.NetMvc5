using DataObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerInterface
{
    public interface ICustomerManager
    {
        List<CustomerVM> GetCustomers();

        CustomerVM GetCustomerById(int id);

        bool AddCustomer(CustomerVM customer);

        bool UpdateCustomer(CustomerVM customer);

        bool DeleteCustomer(int id);

    }
}
