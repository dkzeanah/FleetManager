namespace BlazorApp1.CarModels
{
    public class ExcelDataRecordAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public int ExcelDataRecordId { get; set; }
        public ExcelDataRecord ExcelDataRecord { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Value: {Value}";
        }
    }
}
