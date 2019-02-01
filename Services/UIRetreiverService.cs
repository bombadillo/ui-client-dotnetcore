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
        var url = "http://localhost:3000/component/getComponent/2bca1032-4700-45db-975c-30dae65de7ae/static";

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("94288c19-cda4-48bb-88a6-6b73f27d693a");
        var response = await client.GetAsync(url);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
      }
    }
  }
}