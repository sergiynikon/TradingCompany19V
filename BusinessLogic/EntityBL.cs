using System.Collections.Generic;
using BusinessLogic.Interfaces;
using DAL;
using DTO;

namespace BusinessLogic
{
    public class EntityBL : IEntityBL
    {
        private UserDAL _userDAL;
        private SupplierDAL _supplierDAL;
        private OrderDAL _orderDAL;

        public int AddOrder(OrderDTO order)
        {
            return _orderDAL.AddOrder(order);
        }

        public int AddSupplier(SupplierDTO supplier)
        {
            return _supplierDAL.AddSupplier(supplier);
        }

        public int AddUser(UserDTO user)
        {
            return _userDAL.AddUser(user);
        }

        public int DeleteOrderByID(int id)
        {
            return _orderDAL.DeleteOrderByID(id);
        }

        public int DeleteSupplierByID(int id)
        {
            return _supplierDAL.DeleteSupplierByID(id);
        }

        public List<OrderDTO> GetAllOrders()
        {
            return _orderDAL.GetAllOrders();
        }

        public List<SupplierDTO> GetAllSuppliers()
        {
            return _supplierDAL.GetAllSuppliers();
        }

        public OrderDTO GetOrderByID(int id)
        {
            return _orderDAL.GetOrderByID(id);
        }

        public SupplierDTO GetSupplierByID(int id)
        {
            return _supplierDAL.GetSupplierByID(id);
        }

        public void Update(OrderDTO order)
        {
            _orderDAL.Update(order);
        }

        public UserDTO ValidateLogin(string login, string password)
        {
            return _userDAL.ValidateLogin(login, password);
        }
    }
}
