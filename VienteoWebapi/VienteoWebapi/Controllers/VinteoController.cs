using System.Collections.Generic;
using System.Web.Http;
using VinteoModel.ResponseModel;

namespace VienteoWebapi.Controllers
{
    [RoutePrefix("api/Vinteo")]
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
        [HttpGet]
        [Route("VideoApprove")]
        public IList<VideoResponse> VideoApprove()
        {
            IList<VideoResponse> lstVideoResponse = new List<VideoResponse>();
            try
            {
                for (int i = 1; i <= 2; i++)
                {
                    VideoResponse videoRespose = new VideoResponse
                    {
                        VideoId = i,
                        VideoCode = "Cv0I2mdYlVw",
                        QuestionString = jsonData,
                        IsApproved = false
                    };
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
