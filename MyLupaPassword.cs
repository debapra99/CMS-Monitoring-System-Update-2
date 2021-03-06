﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MyLupaPassword
    {
        public string Email { get; set; }
        public string NamaLengkap { get; set; }
        public string Password { get; set; }
        public string NoTelepon { get; set; }       
        public static bool IsEqual(MyLupaPassword user1, MyLupaPassword user2)
        {
            if (user1 == null || user2 == null) { return false; }
            if (user1.NamaLengkap != user2.NamaLengkap)
            {               
                return false;
            }
            else if (user1.Email != user2.Email)
            {               
                return false;
            }
            else if (user1.NoTelepon != user2.NoTelepon)
            {                
                return false;
            }
            return true;
        }
    }
}
