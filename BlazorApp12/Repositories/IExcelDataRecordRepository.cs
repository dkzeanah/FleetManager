using BlazorApp1.CarModels;
using ClosedXML.Excel;
using System.Collections.Generic;
using System.Threading.Tasks;
using Attribute = BlazorApp1.CarModels.Attribute;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IExcelDataRecordRepository
    {
        //object ExcelDataRecords { get; }

        //ask<ExcelDataRecord> GetByHash(string hash);

        Task<ExcelDataRecord> Get(int id);
        Task<ExcelDataRecord> GetByHash(string hash);
        Task<IEnumerable<ExcelDataRecord>> GetAll();
        Task Add(ExcelDataRecord record);
        Task Update(ExcelDataRecord record);
        Task Delete(int id);
        Task AddChange(ExcelDataRecordChange change);
        Task UpdateColumnData(string columnLetter);
        Task AddAsync(ExcelDataRecord record);
        Task SaveChangesAsync();
        Task AddAsync(ExcelDataRecordChange change);
    }
}
