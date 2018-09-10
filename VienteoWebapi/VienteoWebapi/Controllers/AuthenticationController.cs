using VinteoModel.ResponseModel;
using VinteoModel.RequestModel;
using System.Web.Http;
using VinteoBLL;

namespace VienteoWebapi.Controllers
{
    [RoutePrefix("api/Authentication")]
    public class AuthenticationController : ApiController
    {
        private AuthenticateBll _Auth;
        public AuthenticationController()
        {
            _Auth = new AuthenticateBll();

        }
        [HttpPost]
        [Route("AuthenticateUser")]
        public LoginResponse AuthenticateUser(LoginRequest login)
        {
            LoginResponse loginResponse = new LoginResponse();
            loginResponse = _Auth.GetLogin(login);
            return loginResponse;
        }
        [HttpPost]
        [Route("RegisterUser")]
        public int RegisterUser(RegisterRequest registerRequest)
        {
            return _Auth.RegisterUser(registerRequest);
        }
    }
}
