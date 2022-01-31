using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User.Entity
{
    public class UserEntity
    {
        public Int32 UserId { get; set; }
        public String Name { get; set; }
        public String UserName { get; set; }
        public String Lastname { get; set; }
        public Int32 Active { get; set; }
    }
}