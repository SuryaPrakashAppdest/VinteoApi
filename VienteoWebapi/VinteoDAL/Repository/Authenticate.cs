using System;
using System.Data.SqlClient;
using System.Linq;
using VinteoDAL.EcashDb;
using VinteoDAL.Repository.Interface;
using VinteoModel.RequestModel;
using VinteoModel.ResponseModel;

namespace VinteoDAL.Repository
{
    public class Authenticate : IAuthenticate
    {
        public LoginResponse GetLogin(LoginRequest loginrequest)
        {
            try
            {
                using (var dbCtx = new ECashDbEntities())
                {
                    var autheticate = dbCtx.Database.SqlQuery<LoginResponse>(
                                                        "EXEC sp_login @mobileNo, @password",
                                                       new SqlParameter("mobileNo", loginrequest.UserName),
                                                        new SqlParameter("password", loginrequest.Password)

                                                   )
                                                   .FirstOrDefault();
                    return autheticate;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }
    }
}