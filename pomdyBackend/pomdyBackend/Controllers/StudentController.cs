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
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll()
        {
            return Ok(StudentDAO.GetAll());
        }
        
        [HttpPost]
        public ActionResult<Student> Post([FromBody] Student student)
        {
            // TODO : check doublon (mail,nickname)
            return Ok(StudentDAO.Post(student));
        }
    }
}