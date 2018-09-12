using System.Collections.Generic;
using VinteoDAL.Repository;
using VinteoDAL.Repository.Interface;
using VinteoModel.ResponseModel;

namespace VinteoBLL
{
    public class VinteoMasterBll
    {
        #region "DECLARATIONS"
        IVinteoMaster _VMaster;
        #endregion
        public VinteoMasterBll()
        {
            _VMaster = new VinteoMaster();
        }
        public IList<CatagoryMaster> GetCatagories()
        {
            return _VMaster.GetCatagories();
        }
    }

}