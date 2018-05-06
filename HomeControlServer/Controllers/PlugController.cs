using System.Web.Http;
using System.Web.Http.Cors;
using HomeControlServer.Models;
using HomeControlServer.Logic;

namespace HomeControlServer.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PlugController : ApiController
    {
        private PlugLogic PlugLogic = new PlugLogic();

        [Route("api/plug/get/all")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(PlugLogic.GetAll());
        }

        [Route("api/plug/get/{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(PlugLogic.Get(id));
        }

        [Route("api/plug/get/status/{id}")]
        [HttpGet]
        public IHttpActionResult GetStatus(int id)
        {
            return Ok(PlugLogic.SendData(id, "/status"));
        }

        [Route("api/plug/getid/")]
        [HttpGet]
        public IHttpActionResult GetID(string IP)
        {
            return Ok(PlugLogic.GetID(IP));
        }

        [Route("api/plug/add/")]
        [HttpPut]
        public IHttpActionResult Add(Plug device)
        {
            return Ok(PlugLogic.Add(device));
        }

        [Route("api/plug/delete/{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return Ok(PlugLogic.Delete(id));
        }

        [Route("api/plug/updatedevice/")]
        [HttpPost]
        public IHttpActionResult UpdateDevice(Plug device)
        {
            return null;
        }

        [Route("api/plug/turnoneon/{id}")]
        [HttpPost]
        public IHttpActionResult TurnOneOn(int id)
        {
            return Ok(PlugLogic.SendData(id, "/1/on"));
        }

        [Route("api/plug/turnoneoff/{id}")]
        [HttpPost]
        public IHttpActionResult TurnOneOff(int id)
        {
            return Ok(PlugLogic.SendData(id, "/1/off"));
        }

        [Route("api/plug/turntwoon/{id}")]
        [HttpPost]
        public IHttpActionResult TurnTwoOn(int id)
        {
            return Ok(PlugLogic.SendData(id, "/2/on"));
        }

        [Route("api/plug/turntwooff/{id}")]
        [HttpPost]
        public IHttpActionResult TurnTwoOff(int id)
        {
            return Ok(PlugLogic.SendData(id, "/2/off"));
        }

        [Route("api/plug/turnallon/{id}")]
        [HttpPost]
        public IHttpActionResult TurnAllOn(int id)
        {
            return Ok(PlugLogic.SendData(id, "/on"));
        }

        [Route("api/plug/turnalloff/{id}")]
        [HttpPost]
        public IHttpActionResult TurnAllOff(int id)
        {
            return Ok(PlugLogic.SendData(id, "/off"));
        }
    }
}