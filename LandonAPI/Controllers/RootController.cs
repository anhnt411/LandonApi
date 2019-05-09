using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LandonAPI.Controllers
{
    [Route("/")]
    [ApiController]
    [ApiVersion("1.0")]
    public class RootController : ControllerBase
    {
        [HttpGet(Name =nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var response = new
            {
                hreft = Url.Link(nameof(GetRoot), null),
                rooms = new
                {
                    hreft = Url.Link(nameof(RoomsController.GetRooms), null)
                },
                info = new
                {
                    hreft = Url.Link(nameof(InfoController.GetInfo),null)
                }
            };
            return Ok(response);
        }
    }
}