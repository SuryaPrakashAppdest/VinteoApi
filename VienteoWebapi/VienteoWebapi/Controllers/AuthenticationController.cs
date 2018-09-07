using Model.RequestModel;
using Model.ResponseModel;
using System.Web.Http;
using System.Web.Http.Cors;

namespace VienteoWebapi.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AuthenticationController : ApiController
    {
        [HttpPost]
        [ActionName("api/AuthenticateUser")]
        public LoginResponse AuthenticateUser(LoginRequest login)
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
