using System.Collections.Generic;
using DAL.Interfaces;
using Database;
using DTO;
using AutoMapper;
using System.Linq;
using System.Data.Entity;

namespace DAL
{
    public class SupplierDAL : TradingCompany19Entities, ISupplierDAL
    {
        readonly IMapper _mapper;
        public SupplierDAL()
        {
            var config = new MapperConfiguration(c => c.AddProfiles(typeof(SupplierDAL)));
            _mapper = config.CreateMapper();
        }

        public int AddSupplier(SupplierDTO supplier)
        {
            if (supplier != null)
            {
                using (var db = new SupplierDAL())
                {
                    var newsupplier = db.tblSuppliers.Add(_mapper.Map<tblSupplier>(supplier));
                    db.SaveChanges();
                    return newsupplier.ID;
                }
            }
            return 0;
        }

        public int DeleteSupplierByID(int id)
        {
            using (var db = new SupplierDAL())
            {
                var supplier = _mapper.Map<tblSupplier>(GetSupplierByID(id));

                if (supplier != null)
                {
                    db.Entry(supplier).State = EntityState.Deleted;
                    db.SaveChanges();
                    return 0;
                }
                return 1;
            }
        }

        public List<SupplierDTO> GetAllSuppliers()
        {
            throw new System.NotImplementedException();
        }

        public SupplierDTO GetSupplierByID(int id)
        {
            using (var db = new SupplierDAL())
            {
                return _mapper.Map<SupplierDTO>(db.tblSuppliers.FirstOrDefault(p => p.ID == id));
            }
        }
    }
}
