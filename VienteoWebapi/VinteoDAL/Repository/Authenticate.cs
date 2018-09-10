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
        public int RegisterUser(RegisterRequest registerRequest)
        {
            try
            {
                using (var dbCtx = new ECashDbEntities())
                {
                    var register = dbCtx.Database.SqlQuery<int>(
                                                        "EXEC sp_Register @Username, @Emailid,@MobileNo,@password",
                                                       new SqlParameter("Username", registerRequest.UserName),
                                                        new SqlParameter("Emailid", registerRequest.Password),
                                                        new SqlParameter("MobileNo", registerRequest.MobileNo),
                                                        new SqlParameter("password", registerRequest.Password)
                                                   ).FirstOrDefault();
                    return register;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}