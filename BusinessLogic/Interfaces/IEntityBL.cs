using DTO;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IEntityBL
    {
        OrderDTO GetOrderByID(int id);
        List<OrderDTO> GetAllOrders();
        int AddOrder(OrderDTO order);
        int DeleteOrderByID(int id);
        void Update(OrderDTO order);
        int AddSupplier(SupplierDTO supplier);
        int DeleteSupplierByID(int id);
        SupplierDTO GetSupplierByID(int id);
        List<SupplierDTO> GetAllSuppliers();
        int AddUser(UserDTO user);
        UserDTO ValidateLogin(string login, string password);
    }
}
