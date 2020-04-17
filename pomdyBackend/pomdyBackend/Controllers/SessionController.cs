using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pomdyBackend.DAO;
using pomdyBackend.Model;

namespace pomdyBackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SessionsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Session>> GetAll()
        {
            return Ok(SessionDAO.GetAll());
        }
        
        [HttpPost]
        public ActionResult<Session> Post([FromBody] Session session)
        {
            return Ok(SessionDAO.Post(session));
        }
    }
}