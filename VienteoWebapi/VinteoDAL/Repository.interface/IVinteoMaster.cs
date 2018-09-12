using System.Collections.Generic;
using VinteoModel.ResponseModel;

namespace VinteoDAL.Repository.Interface
{
    public interface IVinteoMaster
    {
        IList<CatagoryMaster> GetCatagories();
    }
}
