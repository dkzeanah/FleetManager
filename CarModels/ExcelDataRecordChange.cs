namespace BlazorApp1.CarModels
{
    public class ExcelDataRecordChange
    {
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime ChangeDate { get; set; }

        public int ExcelDataRecordId { get; set; }
        public required ExcelDataRecord ExcelDataRecord { get; set; }
    }
}
