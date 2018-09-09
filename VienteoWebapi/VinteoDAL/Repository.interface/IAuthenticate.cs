using VinteoModel.ResponseModel;
using VinteoModel.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinteoDAL.Repository.Interface
{
    public interface IAuthenticate
    {
        LoginResponse GetLogin(LoginRequest loginrequest);
    }
}
