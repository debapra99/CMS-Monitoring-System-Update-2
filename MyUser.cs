using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MyUser
    {
        public string NamaLengkap { get; set; }
        public string Email { get; set; }
        public string NoTelepon { get; set; }
        public string Password { get; set; } 
        public static bool IsEqual(MyUser user1, MyUser user2)
        {
            if (user1 ==null || user2==null) { return false; }
            if (user1.NamaLengkap != user2.NamaLengkap)
            {                
                return false;
            }
            else if (user1.Password != user2.Password)
            {               
                return false;
            }
            return true; 
        }
        
    }
    }

