using VinteoModel.ResponseModel;
using VinteoModel.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VinteoDAL.Repository.Interface;

namespace VinteoDAL.Repository
{
    public class Authenticate: IAuthenticate
    {
        public LoginResponse GetLogin(LoginRequest loginrequest)
        {
            LoginResponse loginResponse = new LoginResponse();
            loginResponse.UserId = 1;
            loginResponse.UserName = "Surya";
            loginResponse.EmailId = "suryaprakash.jagarapu@hotmail.com";
            loginResponse.MobileNo = "7095448855";
            return loginResponse;
        }
    }
}