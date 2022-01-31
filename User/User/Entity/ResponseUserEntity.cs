using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User.Entity
{
    public class ResponseUserEntity
    {
        public bool isSuccess { get; set; }
        public string errorCode { get; set; }
        public string errorMessage { get; set; }

        public UserEntity data;
    }
}