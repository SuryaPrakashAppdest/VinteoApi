namespace VinteoModel.ResponseModel
{
    public class RedeemLogRespose
    {
        public string UserName { get; set; }
        public string GatewayName { get; set; }
        public int RedeemPoints { get; set; }
        public string RedeemDate { get; set; }
        public int TotalPoints { get; set; }

        public int BalancePoints { get; set; }
    }
}