namespace Model.ResponseModel
{
    public class VideoResponse
    {
        public int VideoId { get; set; }
        public string VideoCode { get; set; }
        public string QuestionString { get; set; }
        public bool IsApproved { get; set; }
    }
}
