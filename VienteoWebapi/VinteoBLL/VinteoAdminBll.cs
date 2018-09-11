using System.Collections.Generic;
using VinteoDAL.Repository;
using VinteoDAL.Repository.Interface;
using VinteoModel.ResponseModel;

namespace VinteoBLL
{
    public class VinteoAdminBll
    {
        #region "DECLARATIONS"
        IVinteoAdmin _VAdmin;
        #endregion
        public VinteoAdminBll()
        {
            _VAdmin = new VinteoAdmin();
        }
        public IList<VideoResponse> GetVideoList(int catagoryId)
        {
            return _VAdmin.GetVideoList(catagoryId);
        }
    }
}