namespace BlazorApp1.CarModels
{
    public class DataRecord
    {
        public int Id { get; set; }
        public int UploadHistoryId { get; set; }
        public UploadHistory UploadHistory { get; set; }
        public string Key { get; set; } // a key to identify this record
        public string Value { get; set; } // the value of this record
        public DateTime Date { get; set; } // the date this record represents
    }
}
