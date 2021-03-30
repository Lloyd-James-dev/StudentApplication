using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class User {
        
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Mobile { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Pass { get; set; }

        public ICollection<Metadata> Metadatas { get; set; }
        public Admin Admin { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }

    }
}
