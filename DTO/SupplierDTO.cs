using Database;
using System.Collections.Generic;

namespace DTO
{
    public class SupplierDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<tblOrder> tblOrders { get; set; }
    }
}
