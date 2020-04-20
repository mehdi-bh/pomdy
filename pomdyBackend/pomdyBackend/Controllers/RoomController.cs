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
        /***** API Rooms *****/
        [HttpGet]
        public ActionResult<IEnumerable<Room>> GetAll()
        {
            return Ok(RoomDAO.GetAll());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Room> Get(int id)
        {
            Room room = RoomDAO.Get(id);

            return room != null ? (ActionResult<Room>) Ok(room) : NotFound("This room doesn't exist!");
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
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (RoomDAO.Delete(id))
            {
                return Ok();
            }
            return BadRequest();
        }
        
        /***** API RoomStudent *****/
        [HttpGet("{id}/students")]
        public ActionResult<IEnumerable<Student>> GetRoomStudents(int id)
        {
            return Ok(RoomStudentDAO.GetRoomStudents(id));
        }
        
        [HttpPost("{idRoom}/students")]
        public ActionResult<RoomStudent> Post(int idRoom,[FromBody] Student student)
        {
            // TODO : check doublon student déjà dans la room
            RoomStudent roomStudent = new RoomStudent(idRoom,student.Id);
            if (RoomStudentDAO.Post(roomStudent))
            {
                return Ok();
            }
            return BadRequest();
        }
        
        [HttpDelete("{idRoom}/students")]
        public ActionResult<RoomStudent> Delete(int idRoom,[FromBody] Student student)
        {
            RoomStudent roomStudent = new RoomStudent(idRoom,student.Id);
            if (RoomStudentDAO.Delete(roomStudent))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}