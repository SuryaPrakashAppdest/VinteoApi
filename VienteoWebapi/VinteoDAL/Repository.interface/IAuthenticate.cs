using VinteoModel.RequestModel;
using VinteoModel.ResponseModel;

namespace VinteoDAL.Repository.Interface
{
    public interface IAuthenticate
    {
        LoginResponse GetLogin(LoginRequest loginrequest);
        int RegisterUser(RegisterRequest registerRequest);
    }
}
