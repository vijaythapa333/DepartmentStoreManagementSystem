using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartStoreManagementSystem.Class
{
    class TransactionClass
    {
        public int TransactionID { get; set; }
        public string TransactionType { get; set; }
        public string SysUser { get; set; }
        public DateTime TransactioDate { get; set; }
        public decimal GrandTotal { get; set; }
        public DataTable TransactionDetails { get; set; }
    }
    public class TransactionDetails
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Rate { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
