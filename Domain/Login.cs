using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Login
    {
        public int info_id { get; set; }
       
        public string Login_Time { get; set; }
        public string Logout_Time { get; set; }
        public string Logout_type { get; set; }
        public string user_mac_address { get; set; }
    }
}
