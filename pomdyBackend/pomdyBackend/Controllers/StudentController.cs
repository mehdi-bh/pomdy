using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pomdyBackend.DAO;
using pomdyBackend.Model;
using pomdyBackend.Utility;

namespace pomdyBackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StudentsController : ControllerBase
    {
        /***** API Students *****/
        [HttpGet("{nickName}&{password}")]
        public ActionResult<Student> Authenticate(string nickName, string password)
        {
            Student student = StudentDAO.Authenticate(nickName, password);
            return student;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll()
        {
            return Ok(StudentDAO.GetAll());
        }
        
        [HttpGet("{token}")]
        public ActionResult<Student> GetStudentFromToken(string token)
        {
            int id = Security.RetrieveIdFromToken(token);
            Student student = StudentDAO.Get(id);

            return student;
        }
        
        [HttpGet("nickname/{nickName}")]
        public ActionResult<Student> GetStudentByNickName(string nickName)
        {
            Student student = StudentDAO.GetByNickName(nickName);
            return student;
        }
        
        [HttpGet("mail/{mail}")]
        public ActionResult<Student> GetStudentByMail(string mail)
        {
            Student student = StudentDAO.GetByMail(mail);
            return student;
        }
        
        /*[HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            Student student = StudentDAO.Get(id);

            return student != null ? (ActionResult<Student>) Ok(student) : NotFound("This student doesn't exist!");
        }*/
        
        [HttpPost]
        public ActionResult<Student> Post([FromBody] Student student)
        {
            if (StudentDAO.GetByMail(student.Mail) == null && StudentDAO.GetByNickName(student.NickName) == null)
            {
                return Ok(StudentDAO.Post(student));
            }
            return NotFound("This student already exists");
        }
        
        [HttpPut]
        public ActionResult Put([FromBody] Student student)
        {
            Student checkNickNameStudent = StudentDAO.GetByNickName(student.NickName);
            Student checkMailStudent = StudentDAO.GetByMail(student.Mail);

            if (checkNickNameStudent != null && checkNickNameStudent.Id != student.Id 
                ||
                checkMailStudent != null && checkMailStudent.Id != student.Id)
            {
                return NotFound("This student already exists !");
            }

            if (StudentDAO.Put(student))
            {
                return Ok();
            }

            return BadRequest();
        }
        
        [HttpDelete("{token}")]
        public ActionResult Delete(string token)
        {
            int id = Security.RetrieveIdFromToken(token);
            if (StudentDAO.Delete(id))
            {
                return Ok();
            }
            return BadRequest();
        }
        
        /***** API FriendStudent *****/
        [HttpGet("{token}/friends")]
        public ActionResult<IEnumerable<Student>> GetFriends(string token)
        {
            int id = Security.RetrieveIdFromToken(token);
            return Ok(FriendStudentDAO.GetFriends(id));
        }
        
        [HttpPost("friends")]
        public ActionResult<Student> Post([FromBody] Student[] students)
        {
            int[] ids =
            {
                Security.RetrieveIdFromToken(students[0].Token),
                Security.RetrieveIdFromToken(students[1].Token)
            };
            
            FriendStudent[] friendStudents =
            {
                new FriendStudent(ids[0], ids[1]), 
                new FriendStudent(ids[1], ids[0])
            };
            
            if (FriendStudentDAO.Post(friendStudents))
            {
                return Ok();
            }
            return BadRequest();
        }
        
        [HttpDelete("friends")]
        public ActionResult<Student> Delete([FromBody] Student[] students)
        {
            int[] ids =
            {
                Security.RetrieveIdFromToken(students[0].Token),
                Security.RetrieveIdFromToken(students[1].Token)
            };
            
            FriendStudent[] friendStudents =
            {
                new FriendStudent(ids[0], ids[1]), 
                new FriendStudent(ids[1], ids[0])
            };
            
            if (FriendStudentDAO.Delete(friendStudents))
            {
                return Ok();
            }
            return BadRequest();
        }

        /***** API SessionStudent *****/
        [HttpGet("{token}/sessions")]
        public ActionResult<IEnumerable<Session>> GetStudentSessions(string token)
        {
            int id = Security.RetrieveIdFromToken(token);
            return Ok(SessionDAO.GetStudentSessions(id));
        }
        
        /***** API ExtrabreakStudent *****/
        [HttpGet("{token}/extrabreaks")]
        public ActionResult<IEnumerable<Extrabreak>> GetStudentExtrabreaks(string token)
        {
            int id = Security.RetrieveIdFromToken(token);
            return Ok(ExtrabreakDAO.GetStudentExtrabreaks(id));
        }
        
        /***** API RoomStudent *****/
        [HttpGet("{token}/rooms")]
        public ActionResult<IEnumerable<Room>> GetStudentRooms(string token)
        {
            int id = Security.RetrieveIdFromToken(token);
            return Ok(RoomStudentDAO.GetStudentRooms(id));
        }
        
        /***** API TeamStudent *****/
        [HttpGet("{token}/teams")]
        public ActionResult<IEnumerable<Team>> GetStudentTeams(string token)
        {
            int id = Security.RetrieveIdFromToken(token);
            return Ok(TeamStudentDAO.GetStudentTeams(id));
        }
    }
}