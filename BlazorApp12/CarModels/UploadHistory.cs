namespace BlazorApp1.CarModels
{
    public class UploadHistory
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string FileName { get; set; }
        public DateTime UploadTime { get; set; }
        public int NumberOfRecords { get; set; }
    }
}
