namespace VinteoModel.ResponseModel
{
    public class VideoResponse
    {

        public int VideoId { get; set; }
        public int CatagoryId { get; set; }
        public string VideoCode { get; set; }
        public int ContentId { get; set; }
        public string QuestionString { get; set; }
        public int TotalMarks { get; set; }
        public bool IsApproved { get; set; }
    }
}