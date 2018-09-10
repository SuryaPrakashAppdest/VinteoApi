using VinteoDAL.Repository;
using VinteoDAL.Repository.Interface;
using VinteoModel.RequestModel;
using VinteoModel.ResponseModel;

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