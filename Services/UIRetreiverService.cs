namespace ui_client_dotnetcore.Services
{
  using System.Net.Http;
  using System.Net.Http.Headers;
  using System.Threading.Tasks;

  public class UIRetrieverService : IUIRetrieveService {
    
    public async Task<string> RetrieveByToken(string token)
    {
      using (var client = new HttpClient())
      {
        var url = $"http://localhost:3000/component/getComponent/{token}/static";

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("94288c19-cda4-48bb-88a6-6b73f27d693a");
        var response = await client.GetAsync(url);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
      }
    }
  }
}