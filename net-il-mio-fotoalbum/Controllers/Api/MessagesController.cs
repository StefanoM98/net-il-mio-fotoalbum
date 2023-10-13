using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using net_il_mio_fotoalbum.Database;
using net_il_mio_fotoalbum.Models;

namespace net_il_mio_fotoalbum.Controllers.Api
{
    [Route("api/usermessage")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly FotoContext _myDb;

        public MessagesController(FotoContext db)
        {
            _myDb = db;
        }

        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {
            _myDb.Messages.Add(message);

            _myDb.SaveChanges();

            return Ok(message);

        }
    }
}
