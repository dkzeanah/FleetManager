namespace BlazorApp1.CarModels
{
    public class ExcelDataRecord
    {
        public int Id { get; set; }
        public string? Data { get; set; }

        public string? Hash { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime LastModified { get; set; }

        // This property will be used when storing data as JSON
        public string? JsonData { get; set; }

        // These properties will be used when storing data in EAV model
        public ICollection<ExcelDataRecordAttribute>? Attributes { get; set; }
        public ICollection<ExcelDataRecordChange>? Changes { get; set; }
    }
}
    /*public class ExcelDataRecord
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string? DataHash { get; set; }  // To track changes in data
        public DateTime? UploadDate { get; set; }
        public DateTime? LastModified { get; set; }
        public string? JsonData { get; set; }
        //public List<string>? ProcessedColumns { get; set; }

        public ICollection<ExcelDataRecordChange>? Changes { get; set; }

    }*/

