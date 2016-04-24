using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using BotLogic;
using Telegram.Bot.Types;

namespace Web.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/Message/{tokenf}")]
        public OkResult Post(string tokenf, [FromBody]Update value)
        {
            Task.Run(() => new Handler().Handle(value.Message));
            return Ok();
        }
    }
}