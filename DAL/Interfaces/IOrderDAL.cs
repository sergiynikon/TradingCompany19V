using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IOrderDAL
    {
        OrderDTO GetOrderByID(int id);
        List<OrderDTO> GetAllOrders();
        int AddOrder(OrderDTO order);
        int DeleteOrderByID(int id);
        void Update(OrderDTO order);
    }
}
