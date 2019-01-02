using System.Collections.Generic;
using DAL.Interfaces;
using Database;
using DTO;
using AutoMapper;
using System.Linq;
using System.Data.Entity;

namespace DAL
{
    public class OrderDAL : TradingCompany19Entities, IOrderDAL
    {
        readonly IMapper _mapper;
        public OrderDAL()
        {
            var config = new MapperConfiguration(c => c.AddProfiles(typeof(OrderDAL)));
            _mapper = config.CreateMapper();
        }

        public int AddOrder(OrderDTO order)
        {
            if (order != null)
            {
                using (var db = new OrderDAL())
                {
                    var neworder = db.tblOrders.Add(_mapper.Map<tblOrder>(order));
                    db.SaveChanges();
                    return neworder.ID;
                }
            }
            return 0;
        }

        public int DeleteOrderByID(int id)
        {
            using (var db = new OrderDAL())
            {
                var order = _mapper.Map<tblOrder>(GetOrderByID(id));

                if (order != null)
                {
                    db.Entry(order).State = EntityState.Deleted;
                    db.SaveChanges();
                    return 0;
                }
                return 1;
            }
        }

        public List<OrderDTO> GetAllOrders()
        {
            using (var db = new OrderDAL())
            {
                var orders = db.tblOrders.ToList();
                return _mapper.Map<List<OrderDTO>>(orders);
            }
        }

        public OrderDTO GetOrderByID(int id)
        {
            using (var db = new OrderDAL())
            {
                var order = db.tblOrders.FirstOrDefault(o => o.ID == id);
                return _mapper.Map<OrderDTO>(order);
            }
        }

        public void Update(OrderDTO order)
        {
            using (var db = new OrderDAL())
            {
                var old = db.tblOrders.FirstOrDefault(o => o.ID== order.ID);
                old.ProductName = order.ProductName;
                old.CusmomerName = order.CusmomerName;
                old.Price = order.Price;
                old.OrderDate = order.OrderDate;
                db.SaveChanges();
            }
        }
    }
}
