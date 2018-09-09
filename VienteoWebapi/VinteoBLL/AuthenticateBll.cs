using VinteoModel.ResponseModel;
using VinteoModel.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VinteoDAL.Repository.Interface;
using VinteoDAL.Repository;

namespace VinteoBLL
{
    public class AuthenticateBll
    {
        #region "DECLARATIONS"
        IAuthenticate _Auth;
        #endregion

        public AuthenticateBll()
        {
            _Auth = new Authenticate();
        }
        public LoginResponse GetLogin(LoginRequest loginrequest)
        {
            return _Auth.GetLogin(loginrequest);
        }
    }
}