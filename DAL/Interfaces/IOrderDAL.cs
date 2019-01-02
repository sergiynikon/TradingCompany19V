using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IOrderDAL
    {
        OrderDTO GetOrderByID(int id);
        List<OrderDTO> GetAllOrders();
    }
}
