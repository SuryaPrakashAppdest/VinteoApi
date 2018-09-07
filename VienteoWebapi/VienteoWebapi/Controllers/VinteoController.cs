using Model.ResponseModel;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace VienteoWebapi.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VinteoController : ApiController
    {
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
        [ActionName("RedeemLog")]
        public IList<RedeemLogRespose> GetRedeemLog()
        {
            IList<RedeemLogRespose> redeemLog = new List<RedeemLogRespose>();
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    RedeemLogRespose logRespose = new RedeemLogRespose();
                    logRespose.UserName = "User" + i;
                    logRespose.GatewayName = "paytm";
                    logRespose.RedeemPoints = 100;
                    logRespose.RedeemDate = System.DateTime.Now.ToShortDateString();
                    logRespose.TotalPoints = 100;
                    logRespose.BalancePoints = 100;
                    redeemLog.Add(logRespose);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            return redeemLog;
        }
        [HttpGet]
        [ActionName("VideoApprove")]
        public IList<VideoResponse> VideoApprove()
        {
            IList<VideoResponse> lstVideoResponse = new List<VideoResponse>();
            try
            {
                for (int i = 1; i <= 2; i++)
                {
                    VideoResponse videoRespose = new VideoResponse();
                    videoRespose.VideoId = i;
                    videoRespose.VideoCode = "Cv0I2mdYlVw";
                    videoRespose.QuestionString = jsonData;
                    videoRespose.IsApproved = false;
                    lstVideoResponse.Add(videoRespose);
                }
                return lstVideoResponse;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
