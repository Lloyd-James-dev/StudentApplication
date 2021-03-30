using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Receipt {

        public int Id { get; set; }
        public int InvoiceId{ get; set; }
        
        public Invoice Invoice { get; set; }

        public decimal Amount { get; set; }
        public string Misc { get; set; }
        public DateTime ReceiptDate { get; set; }
    }
}
