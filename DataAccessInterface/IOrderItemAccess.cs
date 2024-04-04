using DataObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface
{
    public interface IOrderItemAccess
    {
        List<OrderItemVM> GetOrderItems();

        List<OrderItemVM> GetOrderItems(int orderId);

        OrderItemVM GetOrderItemById(int id);

        bool AddOrderItem(OrderItemVM item);

        bool UpdateOrderItem(OrderItemVM item);

        bool DeleteOrderItem(int id);

    }
}
