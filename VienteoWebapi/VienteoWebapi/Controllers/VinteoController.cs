using System.Collections.Generic;
using System.Web.Http;
using VinteoBLL;
using VinteoModel.ResponseModel;

namespace VienteoWebapi.Controllers
{
    [RoutePrefix("api/Vinteo")]
    public class VinteoController : ApiController
    {
        private VinteoAdminBll _VinteoAdmin;
        public VinteoController()
        {
            _VinteoAdmin = new VinteoAdminBll();

        }
        #region private string
        string jsonData = @"{
'sport': {
            'q1': {
                'question': 'What is the sport Name?',
                'options': [
                    'Cricket',
                    'Football',
                    'Hockey',
                    'Baseball'
                ],
                'answer': 'Cricket',
				'marks':2
            },'q1': {
                'question': 'What is the sport Name1?',
                'options': [
                    'Cricket1',
                    'Football1',
                    'Hockey1',
                    'Baseball1'
                ],
                'answer': 'Cricket1',
				'marks':3
            },
        },
}";
        #endregion
        [HttpGet]
        [Route("RedeemLog")]
        public IList<RedeemLogRespose> GetRedeemLog()
        {
            IList<RedeemLogRespose> redeemLog = new List<RedeemLogRespose>();
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    RedeemLogRespose logRespose = new RedeemLogRespose
                    {
                        UserName = "User" + i,
                        GatewayName = "paytm",
                        RedeemPoints = 100,
                        RedeemDate = System.DateTime.Now.ToShortDateString(),
                        TotalPoints = 100,
                        BalancePoints = 100
                    };
                    redeemLog.Add(logRespose);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            return redeemLog;
        }

        [HttpPost]
        [Route("VideoContent")]
        public IList<VideoResponse> VideoContent(int catagoryId)
        {
            IList<VideoResponse> lstVideoResponse = new List<VideoResponse>();
            try
            {
                   return _VinteoAdmin.GetVideoList(catagoryId);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
