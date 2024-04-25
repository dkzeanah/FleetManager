using BlazorApp1.CarModels;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp1.Interfaces
{
    public interface IExcelDataRecordService
    {
        Task<List<Dictionary<string, object>>> ProcessExcelFileToJson(IBrowserFile file);
        public Task<IEnumerable<ExcelDataRecord>> GetAll();

        Task<List<Dictionary<string, object>>> ProcessExcelFile(IBrowserFile file);
        Task<List<Dictionary<string, object>>> ProcessExcelFileAndTrackChanges(IBrowserFile file);
        Task<List<Dictionary<string, object>>> ProcessExcelFileBasedOnTitle(IBrowserFile file);
        //Task
        Task<string> GenerateExcelFile(int id);
    }
}
