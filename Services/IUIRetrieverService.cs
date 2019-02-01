using System.Threading.Tasks;

namespace ui_client_dotnetcore.Services
{
  public interface IUIRetrieveService 
  {
    Task<string> RetrieveByToken(string token);
  }
}