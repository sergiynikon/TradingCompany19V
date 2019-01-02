using Database;

namespace DTO
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public string CusmomerName { get; set; }
        public decimal Price { get; set; }
        public System.DateTime OrderDate { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }
    }
}
