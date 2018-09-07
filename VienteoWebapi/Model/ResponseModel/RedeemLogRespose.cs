using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ResponseModel
{
    public class RedeemLogRespose
    {
        public string UserName { get; set; }
        public int TotalPoints { get; set; }
        public int RedeemPoints { get; set; }
        public int BalancePoints { get; set; }
        public string GatewayName { get; set; }
        public string RedeemDate { get; set; }

    }
}
