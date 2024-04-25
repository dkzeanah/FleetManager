using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Newtonsoft.Json.Linq;

namespace BlazorApp1.Services
{
    using Microsoft.AspNetCore.Components.Forms;
    using ClosedXML.Excel;
    using System.IO;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Threading.Tasks;
    using global::BlazorApp1.Data;
    using global::BlazorApp1.CarModels;
    using System.Collections;
    using global::BlazorApp1.Repositories.Interfaces;
    using global::BlazorApp1.Repositories;
    using Newtonsoft.Json;
    using System.Text;
    using System.Security.Cryptography;
    using Microsoft.EntityFrameworkCore;
    using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
    using global::BlazorApp1.Services.Interfaces;

    public class ExcelDataRecordService : IExcelDataRecordService
    {
        private readonly IExcelDataRecordRepository _context;
        private HashSet<string> processedColumns = new HashSet<string>();

        //Constructor
        public ExcelDataRecordService(IExcelDataRecordRepository excelDataRecordRepository)
        {
            _context = excelDataRecordRepository;
        }

        // To process Excel file and store data as 'normal' or 'regular' data
        public async Task<List<Dictionary<string, object>>> ProcessExcelFile(IBrowserFile file)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file), "The input file cannot be null.");
            }
            // Convert the file to a stream.
            await using var memoryStream = new MemoryStream();
            await file.OpenReadStream(maxAllowedSize: 512000).CopyToAsync(memoryStream);

            // Use ClosedXML to read the Excel data.
            var workbook = new XLWorkbook(memoryStream);
            var worksheet = workbook.Worksheet(1);
            var rows = worksheet.RowsUsed();

            var data = new List<Dictionary<string, object>>();

            // Create a dictionary to store the title and its corresponding hash

            Dictionary<string, string> titleHash = new Dictionary<string, string>();

            // Iterate through the rows of the Excel file.
            foreach (var rowdata in rows)
            {
                var rowData = new Dictionary<string, object>();
                string titleKey = string.Empty;
                string titleHashKey = string.Empty;

                foreach (var cell in rowdata.Cells())
                {
                    rowData[cell.Address.ColumnLetter] = cell.Value;

                    // Update column data
                    await _context.UpdateColumnData(cell.Address.ColumnLetter);

                    // If the cell's column is the "Title", process it
                    if (cell.Address.ColumnLetter == "Title")
                    {
                        //titleKey = ProcessTitle(cell.Value).ToString();  // Implement a method to strip, tokenize and bucketize the title
                        Console.WriteLine(titleKey);
                        titleHashKey = GetHash(titleKey);
                    }
                }
                var dataJson = JsonConvert.SerializeObject(rowData);
                var dataHash = GetHash(dataJson); // Implement a method to generate a hash

                // Check if a title with the same hash already exists
                if (titleHash.ContainsKey(titleKey) && titleHash[titleKey] == titleHashKey)
                {
                    // The row is exactly the same as before, skip it
                    Console.WriteLine("Hash Exist, no new record");
                    continue;
                }
                else
                {
                    titleHash[titleKey] = titleHashKey;
                    // Rest of your logic

                }
                var newRecord = new ExcelDataRecord { Data = dataJson, Hash = dataHash, UploadDate = DateTime.Now, LastModified = DateTime.Now };
                await _context.Add(newRecord);
                Console.WriteLine("New record added");
                data.Add(rowData);

            }
            return data;
        }
        /* public async Task<List<Dictionary<string, object>>> ProcessExcelFileToJson(IBrowserFile file)
         {
             if (file == null)
             {
                 throw new ArgumentNullException(nameof(file), "The input file cannot be null.");
             }
             // Convert the file to a stream.
             await using var memoryStream = new MemoryStream();
             await file.OpenReadStream(maxAllowedSize: 512000).CopyToAsync(memoryStream);

             // Use ClosedXML to read the Excel data.
             var workbook = new XLWorkbook(memoryStream);
             var worksheet = workbook.Worksheet(1);
             var rows = worksheet.RowsUsed();

             var data = new List<Dictionary<string, object>>();

             // Create a dictionary to store the title and its corresponding hash

             Dictionary<string, string> titleHash = new Dictionary<string, string>();

             // Iterate through the rows of the Excel file.
             foreach (var rowdata in rows)
             {
                 var rowData = new Dictionary<string, object>();
                 string titleKey = string.Empty;
                 string titleHashKey = string.Empty;

                 foreach (var cell in rowdata.Cells())
                 {
                     rowData[cell.Address.ColumnLetter] = cell.Value;

                     // Update column data
                     await _context.UpdateColumnData(cell.Address.ColumnLetter);

                     // If the cell's column is the "Title", process it
                     if (cell.Address.ColumnLetter == "Title")
                     {
                         //titleKey = ProcessTitle(cell.Value).ToString();  // Implement a method to strip, tokenize and bucketize the title
                         Console.WriteLine(titleKey);
                         titleHashKey = GetHash(titleKey);
                     }
                 }
                 var dataJson = JsonConvert.SerializeObject(rowData);
                 var dataHash = GetHash(dataJson); // Implement a method to generate a hash

                 // Check if a title with the same hash already exists
                 if (titleHash.ContainsKey(titleKey) && titleHash[titleKey] == titleHashKey)
                 {
                     // The row is exactly the same as before, skip it
                     Console.WriteLine("Hash Exist, no new record");
                     continue;
                 }
                 else
                 {
                     titleHash[titleKey] = titleHashKey;
                     // Rest of your logic

                 }
                 var newRecord = new ExcelDataRecord { Data = dataJson, DataHash = dataHash, UploadDate = DateTime.Now, LastModified = DateTime.Now };
                 await _context.Add(newRecord);
                 Console.WriteLine("New record added");
                 data.Add(rowData);

             }
             return data;
         }*/
        public async Task<List<Dictionary<string, object>>> ProcessExcelFileToJson(IBrowserFile file)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file), "The input file cannot be null.");
            }
            // Convert the file to a stream.
            await using var memoryStream = new MemoryStream();
            await file.OpenReadStream(maxAllowedSize: 512000).CopyToAsync(memoryStream);

            // Use ClosedXML to read the Excel data.
            var workbook = new XLWorkbook(memoryStream);
            var worksheet = workbook.Worksheet(1);
            var rows = worksheet.RowsUsed();

            var data = new List<Dictionary<string, object>>();

            // Create a dictionary to store the title and its corresponding hash

            Dictionary<string, string> titleHash = new Dictionary<string, string>();

            // Iterate through the rows of the Excel file.
            foreach (var rowdata in rows)
            {
                var rowData = new Dictionary<string, object>();
                string titleKey = string.Empty;
                string titleHashKey = string.Empty;

                foreach (var cell in rowdata.Cells())
                {
                    rowData[cell.Address.ColumnLetter] = cell.Value;

                    // Update column data
                    await _context.UpdateColumnData(cell.Address.ColumnLetter);

                    // If the cell's column is the "Title", process it
                    if (cell.Address.ColumnLetter == "Title")
                    {
                        titleKey = cell.Value.ToString();  // Implement a method to strip, tokenize and bucketize the title
                        Console.WriteLine(titleKey);
                        titleHashKey = GetHash(titleKey);
                    }
                }
                var dataJson = JsonConvert.SerializeObject(rowData);
                var dataHash = GetHash(dataJson); // Implement a method to generate a hash

               /* // Check if a title with the same hash already exists
                if (titleHash.ContainsKey(titleKey) && titleHash[titleKey] == titleHashKey)
                {
                    // The row is exactly the same as before, skip it
                    Console.WriteLine("Hash Exist, no new record");
                    continue;
                }
                else
                {
                    titleHash[titleKey] = titleHashKey;
                    // Rest of your logic

                }*/
                var newRecord = new ExcelDataRecord { Data = dataJson, Hash = dataHash, JsonData = dataJson, UploadDate = DateTime.Now, LastModified = DateTime.Now };
                await _context.Add(newRecord);
                Console.WriteLine("New record added");
                data.Add(rowData);

            }
            return data;
        }

        public async Task<List<Dictionary<string, object>>> ProcessExcelFile11(IBrowserFile file)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file), "The input file cannot be null.");
            }
            // Convert the file to a stream.
            await using var memoryStream = new MemoryStream();
            await file.OpenReadStream(maxAllowedSize: 512000).CopyToAsync(memoryStream);

            // Use ClosedXML to read the Excel data.
            var workbook = new XLWorkbook(memoryStream);
            var worksheet = workbook.Worksheet(1);
            var rows = worksheet.RowsUsed();

            var data = new List<Dictionary<string, object>>();

            // Iterate through the rows of the Excel file.
            foreach (var rowdata in rows)
            {
                var rowData = new Dictionary<string, object>();

                foreach (var cell in rowdata.Cells())
                {
                    rowData[cell.Address.ColumnLetter] = cell.Value;
                }

                var dataJson = JsonConvert.SerializeObject(rowData);
                var dataHash = GetHash(dataJson); // Implement a method to generate a hash

                // Check if a record with the same hash already exists
                var existingRecord = await _context.GetByHash(dataHash);


                if (existingRecord != null)
                {
                    var oldData = JsonConvert.DeserializeObject<Dictionary<string, object>>(existingRecord.Data);
                    var newData = JsonConvert.DeserializeObject<Dictionary<string, object>>(dataJson);

                    // Compare old and new data
                    foreach (var pair in newData)
                    {
                        if (!oldData.TryGetValue(pair.Key, out var oldValue) || !pair.Value.Equals(oldValue))
                        {
                            // Value has changed
                            var change = new ExcelDataRecordChange
                            {
                                ColumnName = pair.Key,
                                OldValue = oldValue?.ToString(),
                                NewValue = pair.Value.ToString(),
                                ChangeDate = DateTime.Now,
                                ExcelDataRecord = existingRecord,
                                ExcelDataRecordId = existingRecord.Id
                            };
                            await _context.AddChange(change);
                        }
                    }
                    existingRecord.Data = dataJson;
                    existingRecord.LastModified = DateTime.Now;
                    await _context.Update(existingRecord);
                }
                else
                {
                    // Add new record
                    var newRecord = new ExcelDataRecord { Data = dataJson, Hash = dataHash, UploadDate = DateTime.Now, LastModified = DateTime.Now };
                    await _context.Add(newRecord);
                }
            }

            // Return the extracted data
            return data;
        }
        
        public async Task<List<Dictionary<string, object>>> ProcessExcelFileToJson10(IBrowserFile file)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file), "The input file cannot be null.");
            }
            // Convert the file to a stream.
            await using var memoryStream = new MemoryStream();
            await file.OpenReadStream(maxAllowedSize: 512000).CopyToAsync(memoryStream);

            // Use ClosedXML to read the Excel data.
            var workbook = new XLWorkbook(memoryStream);
            var worksheet = workbook.Worksheet(1);
            var rows = worksheet.RowsUsed();

            var data = new List<Dictionary<string, object>>();

            // Create a dictionary to store the title and its corresponding hash

            Dictionary<string, string> titleHash = new Dictionary<string, string>();

            // Iterate through the rows of the Excel file.
            foreach (var rowdata in rows)
            {
                var rowData = new Dictionary<string, object>();
                string titleKey = string.Empty;
                string titleHashKey = string.Empty;

                foreach (var cell in rowdata.Cells())
                {
                    rowData[cell.Address.ColumnLetter] = cell.Value;

                    // Update column data
                    await _context.UpdateColumnData(cell.Address.ColumnLetter);

                    // If the cell's column is the "Title", process it
                    if (cell.Address.ColumnLetter == "Title")
                    {
                        //titleKey = ProcessTitle(cell.Value.ToString());  // Implement a method to strip, tokenize and bucketize the title
                        Console.WriteLine(titleKey);
                        titleHashKey = GetHash(titleKey);
                    }
                }
                var dataJson = JsonConvert.SerializeObject(rowData);
                var dataHash = GetHash(dataJson); // Implement a method to generate a hash

                // Check if a title with the same hash already exists
                if (titleHash.ContainsKey(titleKey) && titleHash[titleKey] == titleHashKey)
                {
                    // The row is exactly the same as before, skip it
                    Console.WriteLine("Hash Exist, no new record");
                    continue;
                }
                else
                {
                    titleHash[titleKey] = titleHashKey;
                    // Rest of your logic

                }
                var newRecord = new ExcelDataRecord { Data = dataJson, Hash = dataHash, UploadDate = DateTime.Now, LastModified = DateTime.Now };
                await _context.Add(newRecord);
                Console.WriteLine("New record added");
                data.Add(rowData);

            }
            return data;
        }

        public Task UpdateColumnData(string columnLetter)
        {
            // If the column has not been processed before, add it to the set and print a message
            if (!processedColumns.Contains(columnLetter))
            {
                processedColumns.Add(columnLetter);
                Console.WriteLine($"Processing column {columnLetter} for the first time");
            }

            return Task.CompletedTask;
        }
        // To process Excel file and track changes
        public async Task<List<Dictionary<string, object>>> ProcessExcelFileAndTrackChanges(IBrowserFile file)
        {
            var data = await ReadExcelFile(file);

            foreach (var record in data)
            {
                var dataJson = JsonConvert.SerializeObject(record);
                var dataHash = GetHash(dataJson);

                var existingRecord = await _context.GetByHash(dataHash);
                if (existingRecord != null)
                {
                    var oldData = JsonConvert.DeserializeObject<Dictionary<string, object>>(existingRecord.Data);
                    foreach (var pair in record)
                    {
                        if (!oldData.TryGetValue(pair.Key, out var oldValue) || !pair.Value.Equals(oldValue))
                        {
                            var change = new ExcelDataRecordChange
                            {
                                ColumnName = pair.Key,
                                OldValue = oldValue?.ToString(),
                                NewValue = pair.Value.ToString(),
                                ChangeDate = DateTime.Now,
                                ExcelDataRecord = existingRecord,
                                ExcelDataRecordId = existingRecord.Id
                            };
                            await _context.AddChange(change);
                        }
                    }

                    existingRecord.Data = dataJson;
                    existingRecord.LastModified = DateTime.Now;
                    await _context.Update(existingRecord);
                }
                else
                {
                    var newRecord = new ExcelDataRecord { Data = dataJson, Hash = dataHash, UploadDate = DateTime.Now, LastModified = DateTime.Now };
                    await _context.Add(newRecord);
                }
            }

            return data;
        }

       /* private string ProcessTitle(string data)
        {
            // Example: This method simply returns the original title.
            // Update this according to your needs
            return value;
        }*/

        private string GetHash(string data)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public async Task<string> GenerateExcelFile(int id)
        {
            // Get the data record from the database.
            var record = await _context.Get(id);

            if (record == null)
            {
                throw new Exception($"Record with id {id} not found");
            }

            // Deserialize the JSON data.
            var data = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(record.Data);

            // Use ClosedXML to create a new Excel file.
            var workbook = new XLWorkbook();
            var worksheet = workbook.AddWorksheet("Sheet1");

            var rowIndex = 1;
            foreach (var row in data)
            {
                var columnIndex = 1;
                foreach (var cell in row)
                {
                    // Use the column letter as the header in the first row.
                    if (rowIndex == 1)
                    {
                        worksheet.Cell(1, columnIndex).Value = cell.Key;
                    }

                    // Add the cell value.
                    worksheet.Cell(rowIndex + 1, columnIndex).Value = (XLCellValue)cell.Value;

                    columnIndex++;
                }

                rowIndex++;
            }

            // Convert the workbook to a base64 string.
            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            var base64 = Convert.ToBase64String(stream.ToArray());

            return base64;
        }
        // To process Excel file and track changes
        public async Task<List<Dictionary<string, object>>> ProcessExcelFileAndTrackChanges2(IBrowserFile file)
        {
            var data = await ReadExcelFile(file);

            foreach (var record in data)
            {
                var dataJson = JsonConvert.SerializeObject(record);
                var dataHash = GetHash(dataJson);

                var existingRecord = await _context.GetByHash(dataHash);
                if (existingRecord != null)
                {
                    var oldData = JsonConvert.DeserializeObject<Dictionary<string, object>>(existingRecord.Data);
                    foreach (var pair in record)
                    {
                        if (!oldData.TryGetValue(pair.Key, out var oldValue) || !pair.Value.Equals(oldValue))
                        {
                            var change = new ExcelDataRecordChange
                            {
                                ColumnName = pair.Key,
                                OldValue = oldValue?.ToString(),
                                NewValue = pair.Value.ToString(),
                                ChangeDate = DateTime.Now,
                                ExcelDataRecord = existingRecord,
                                ExcelDataRecordId = existingRecord.Id
                            };
                            await _context.AddChange(change);
                        }
                    }
                    existingRecord.Data = dataJson;
                    existingRecord.LastModified = DateTime.Now;
                    await _context.Update(existingRecord);
                }
                else
                {
                    var newRecord = new ExcelDataRecord { Data = dataJson, Hash = dataHash, UploadDate = DateTime.Now, LastModified = DateTime.Now };
                    await _context.Add(newRecord);
                }
            }
            return data;
        }
        // To process Excel file based on title
        public async Task<List<Dictionary<string, object>>> ProcessExcelFileBasedOnTitle(IBrowserFile file)
        {
            var data = await ReadExcelFile(file);
            // You need to define what 'based on title' means in this context and implement your logic here
            return data;
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
                }
                data.Add(rowData);
            }
            return data;
        }
    }
}
