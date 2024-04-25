using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp1.Services.Interfaces
{
    public interface IExcelDataRecordService
    {
        /*Task<List<Dictionary<string, object>>> ProcessExcelFile(IBrowserFile file);
        Task<string> GenerateExcelFile(int id);*/
        Task<List<Dictionary<string, object>>> ProcessExcelFileToJson(IBrowserFile file);

        Task<List<Dictionary<string, object>>> ProcessExcelFile(IBrowserFile file);
        Task<List<Dictionary<string, object>>> ProcessExcelFileAndTrackChanges(IBrowserFile file);
        Task<List<Dictionary<string, object>>> ProcessExcelFileBasedOnTitle(IBrowserFile file);

        Task<string> GenerateExcelFile(int id);
    }
}
