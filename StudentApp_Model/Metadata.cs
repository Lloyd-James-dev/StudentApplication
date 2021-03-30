using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Metadata {
        public int Id { get; set; }

        public string UserId { get; set; }

        public DateTime TimeStamp { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }

    }
}
