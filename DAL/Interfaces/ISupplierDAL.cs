using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ISupplierDAL
    {
        int AddSupplier(SupplierDTO supplier);
        int DeleteSuppliersByID(int id);
        SupplierDTO GetSupplierByID(int id);
        List<SupplierDTO> GetAllSuppliers();
    }
}
