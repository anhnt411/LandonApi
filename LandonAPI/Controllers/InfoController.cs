using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandonAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LandonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly HolteInfo _info;

        public InfoController(IOptions<HolteInfo> option)
        {
            this._info = option.Value;
        }

        [HttpGet(Name = nameof(GetInfo))]
        [ProducesResponseType(200)]
        public ActionResult<HolteInfo> GetInfo()
        {
            _info.Href = Url.Link(nameof(GetInfo), null);
            return _info;
        }
    }
}