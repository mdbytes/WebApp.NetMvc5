using DataObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface
{
    public interface IOrderAccess
    {
        List<OrderVM> GetOrders();

        OrderVM GetOrderVMById(int id);

        bool AddOrder(OrderVM orderVM);

        bool UpdateOrder(OrderVM orderVM);

        bool DeleteOrder(int id);

    }
}
