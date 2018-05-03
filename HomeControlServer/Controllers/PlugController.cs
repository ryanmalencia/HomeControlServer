using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using HomeControlServer.Models;

namespace HomeControlServer.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PlugController : ApiController
    {
        [Route("api/plug/getalldevices")]
        [HttpGet]
        public IHttpActionResult GetAllDevices()
        {
            return null;
        }

        [Route("api/plug/getdevice/{id}")]
        [HttpGet]
        public IHttpActionResult GetDevice(int id)
        {
            return null;
        }

        [Route("api/plug/add/")]
        [HttpPut]
        public IHttpActionResult Add(Plug device)
        {
            return null;
        }

        [Route("api/plug/delete/{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return null;
        }

        [Route("api/plug/updatedevice/")]
        [HttpPost]
        public IHttpActionResult GetAllDevices(Plug device)
        {
            return null;
        }

        [Route("api/plug/turnoneon/{id}")]
        [HttpPost]
        public IHttpActionResult TurnOneOn(int id)
        {
            return Ok("wow");
        }

        [Route("api/plug/turnoneoff/{id}")]
        [HttpPost]
        public IHttpActionResult TurnOneOff(int id)
        {
            return null;
        }

        [Route("api/plug/turntwoon/{id}")]
        [HttpPost]
        public IHttpActionResult TurnTwoOn(int id)
        {
            return null;
        }

        [Route("api/plug/turntwooff/{id}")]
        [HttpPost]
        public IHttpActionResult TurnTwoOff(int id)
        {
            return null;
        }

        [Route("api/plug/turnallon/{id}")]
        [HttpPost]
        public IHttpActionResult TurnAllOn(int id)
        {
            return null;
        }

        [Route("api/plug/turnalloff/{id}")]
        [HttpPost]
        public IHttpActionResult TurnAllOff(int id)
        {
            return null;
        }
    }
}