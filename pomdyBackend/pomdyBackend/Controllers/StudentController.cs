using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pomdyBackend.DAO;
using pomdyBackend.Model;

namespace pomdyBackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StudentsController : ControllerBase
    {
        /***** API Students *****/
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll()
        {
            return Ok(StudentDAO.GetAll());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            Student student = StudentDAO.Get(id);

            return student != null ? (ActionResult<Student>) Ok(student) : NotFound("This student doesn't exist!");
        }
        
        [HttpPost]
        public ActionResult<Student> Post([FromBody] Student student)
        {
            // TODO : check doublon (mail,nickname)
            return Ok(StudentDAO.Post(student));
        }
        
        [HttpPut]
        public ActionResult Put([FromBody] Student student)
        {
            if (StudentDAO.Put(student))
            {
                return Ok();
            }

            return BadRequest();
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (StudentDAO.Delete(id))
            {
                return Ok();
            }
            return BadRequest();
        }
        
        /***** API FriendStudent *****/
        [HttpPost("friends")]
        public ActionResult<Student> Post([FromBody] Student[] student)
        {
            FriendStudent[] friendStudents =
                {
                    new FriendStudent(student[0].Id, student[1].Id), 
                    new FriendStudent(student[1].Id, student[0].Id)
                };
            
            if (FriendStudentDAO.Post(friendStudents))
            {
                return Ok();
            }
            return BadRequest();
        }
        
        [HttpDelete("friends")]
        public ActionResult<Student> Delete([FromBody] Student[] student)
        {
            FriendStudent[] friendStudents =
            {
                new FriendStudent(student[0].Id, student[1].Id), 
                new FriendStudent(student[1].Id, student[0].Id)
            };
            
            if (FriendStudentDAO.Delete(friendStudents))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}