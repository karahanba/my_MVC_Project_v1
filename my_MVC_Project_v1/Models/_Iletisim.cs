using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_MVC_Project_v1.Models
{
    public class _Iletisim
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        // Below columns were added after
        public string About { get; set; }
        public string Privacy { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
    }
}
