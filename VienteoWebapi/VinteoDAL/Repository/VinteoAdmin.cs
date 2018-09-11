using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using VinteoDAL.EcashDb;
using VinteoDAL.Repository.Interface;
using VinteoModel.ResponseModel;

namespace VinteoDAL.Repository
{
    public class VinteoAdmin: IVinteoAdmin
    {
        public IList<VideoResponse> GetVideoList(int catagoryId)
        {
            List<VideoResponse> listVideo = new List<VideoResponse>();
            try
            {
                using (var dbCtx = new ECashDbEntities())
                {
                    listVideo = dbCtx.Database.SqlQuery<VideoResponse>(
                                                         "EXEC sp_GetVideoContent @CatagoryId",
                                                        new SqlParameter("CatagoryId", catagoryId)
                                                    )
                                                    .ToList();
                    return listVideo;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}