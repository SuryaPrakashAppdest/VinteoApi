using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinteoModel.ResponseModel
{
    public class LoginResponse
    {
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
    }
}