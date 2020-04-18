using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pomdyBackend.DAO;
using pomdyBackend.Model;

namespace pomdyBackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class RoomsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Room>> GetAll()
        {
            return Ok(RoomDAO.GetAll());
        }
        
        [HttpPost]
        public ActionResult<Room> Post([FromBody] Room room)
        {
            return Ok(RoomDAO.Post(room));
        }
        
        [HttpPut]
        public ActionResult Put([FromBody] Room room)
        {
            if (RoomDAO.Put(room))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}