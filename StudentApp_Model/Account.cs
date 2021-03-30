using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Account {

        public int Id { get; set; }

        public string StudentEmail { get; set; }
        public int? InvoiceId { get; set; }
        public int? ReceiptId { get; set; }

        public Student Student { get; set; }
        public Invoice Invoice { get; set; }
        public Receipt Receipt { get; set; }
    }
}
