namespace BlazorApp1.CarModels.Utils
{
  using System.Text.Json;
  using System.IO;
  using System.Threading.Tasks;
  using BlazorApp1.CarModels.Sets;

  public class JsonFileParser
  {
    public async Task<DatabaseSchema> DeserializeJsonFileAsync(string filePath)
    {
      using (FileStream fs = File.OpenRead(filePath))
      {
        return await JsonSerializer.DeserializeAsync<DatabaseSchema>(fs);
      }
    }
  }

}
