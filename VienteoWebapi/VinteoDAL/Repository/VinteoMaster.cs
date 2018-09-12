using System;
using System.Collections.Generic;
using System.Linq;
using VinteoDAL.EcashDb;
using VinteoDAL.Repository.Interface;
using VinteoModel.ResponseModel;

namespace VinteoDAL.Repository
{
    public class VinteoMaster : IVinteoMaster
    {
        public IList<CatagoryMaster> GetCatagories()
        {
            List<CatagoryMaster> listCatagory = new List<CatagoryMaster>();
            try
            {
                using (var dbCtx = new ECashDbEntities())
                {
                    listCatagory = dbCtx.Database.SqlQuery<CatagoryMaster>(
                                                         "EXEC sp_GetCatagories"
                                                    )
                                                    .ToList();
                    return listCatagory;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}