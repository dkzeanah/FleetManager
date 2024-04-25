namespace BlazorApp1.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    using System.Security.Cryptography;
    using Microsoft.AspNetCore.Components.Forms;
    using ClosedXML.Excel;
    using global::BlazorApp1.Interfaces;

    namespace BlazorApp1.Services
    {
        public class ExcelDataRecordService : IExcelDataRecordService
        {
            private readonly IExcelDataRecordRepository _context;
            private readonly HashSet<string> _processedColumns = new HashSet<string>();

            public ExcelDataRecordService(IExcelDataRecordRepository excelDataRecordRepository)
            {
                _context = excelDataRecordRepository;
            }

            private async Task<List<Dictionary<string, object>>> ReadExcelFile(IBrowserFile file)
            {
                if (file == null)
                {
                    throw new ArgumentNullException(nameof(file), "The input file cannot be null.");
                }

                await using var memoryStream = new MemoryStream();
                await file.OpenReadStream(maxAllowedSize: 512000).CopyToAsync(memoryStream);

                var workbook = new XLWorkbook(memoryStream);
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RowsUsed();

                var data = new List<Dictionary<string, object>>();
                foreach (var row in rows)
                {
                    var rowData = new Dictionary<string, object>();
                    foreach (var cell in row.Cells())
                    {
                        rowData[cell.Address.ColumnLetter] = cell.Value;
                        if (!_processedColumns.Contains(cell.Address.ColumnLetter))
                        {
                            _processedColumns.Add(cell.Address.ColumnLetter);
                            await _context.UpdateColumnData(cell.Address.ColumnLetter);
                        }
                    }
                    data.Add(rowData);
                }
                return data;
            }

            private string GetHash(string data)
            {
                using (var sha256 = SHA256.Create())
                {
                    var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                }
            }

            public async Task<List<Dictionary<string, object>>> ProcessExcelFile(IBrowserFile file)
            {
                // Same code you had but now leverage ReadExcelFile
                var data = await ReadExcelFile(file);
                // Further logic...
                // ...
                return data;
            }

            public async Task<List<Dictionary<string, object>>> ProcessExcelFileToJson(IBrowserFile file)
            {
                // Same code you had but now leverage ReadExcelFile
                var data = await ReadExcelFile(file);
                // Further logic...
                // ...
                return data;
            }

            public async Task<List<Dictionary<string, object>>> ProcessExcelFileAndTrackChanges(IBrowserFile file)
            {
                // Same code you had but now leverage ReadExcelFile
                var data = await ReadExcelFile(file);
                // Further logic...
                // ...
                return data;
            }

            public Task<IEnumerable<CarModels.ExcelDataRecord>> GetAll()
            {
                throw new NotImplementedException();
            }

            public Task<List<Dictionary<string, object>>> ProcessExcelFileBasedOnTitle(IBrowserFile file)
            {
                throw new NotImplementedException();
            }

            public Task<string> GenerateExcelFile(int id)
            {
                throw new NotImplementedException();
            }

            // ... rest of your methods
        }
    }

}
