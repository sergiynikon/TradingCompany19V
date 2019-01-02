using System.Collections.Generic;
using DAL.Interfaces;
using Database;
using DTO;

namespace DAL
{
    class OrderDAL : TradingCompany19Entities, IOrderDAL
    {
        public List<OrderDTO> GetAllOrders()
        {
            throw new System.NotImplementedException();
        }

        public OrderDTO GetOrderByID(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
