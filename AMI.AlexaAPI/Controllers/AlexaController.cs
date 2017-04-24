using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AMI.AlexaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AMI.AlexaAPI.Controllers
{
  [Route("api/[controller]/[action]")]
  public class AlexaController : ApiController
  {
    // [HttpPost]
    // public async Task<HttpResponseMessage> TalkToMe()
    // {
    //   var speechlet = new MySpeechletServiceAsync();
    //   return await speechlet.GetResponseAsync(Request);
    // }

    [HttpPost]
    public HttpResponseMessage TalkToMe(){
        var speechlet = new MySpeechletService();
        return speechlet.GetResponse(Request);
    }
  }
}