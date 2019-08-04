using Microsoft.AspNetCore.Mvc;
using ApiControllers.Models;


namespace ApiControllers.Controllers
{
    [Route ("api/[controller]")]
    public class ContentController : Controller
    {

        [HttpGet("string")]
        public string GetString() => "This is a String response";

        [HttpGet("object/{format?}")]
        [FormatFilter]
        public Reservation GetObject() => new Reservation
        {
            ReservationId = 100,
            ClientName = "Joy",
            Location = "Board Room"
        };

    }
}
