using System.Collections.Generic;
using VinteoModel.ResponseModel;

namespace VinteoDAL.Repository.Interface
{
    public interface IVinteoAdmin
    {
        IList<VideoResponse> GetVideoList(int catagoryId);
    }
}
