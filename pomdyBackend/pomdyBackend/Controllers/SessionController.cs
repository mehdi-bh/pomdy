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
        /***** API Sessions *****/
        [HttpGet]
        public ActionResult<IEnumerable<Session>> GetAll()
        {
            return Ok(SessionDAO.GetAll());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Session> Get(int id)
        {
            Session session = SessionDAO.Get(id);

            return session != null ? (ActionResult<Session>) Ok(session) : NotFound("This session doesn't exist!");
        }
        
        [HttpPost]
        public ActionResult<Session> Post([FromBody] Session session)
        {
            return Ok(SessionDAO.Post(session));
        }
        
        [HttpPut]
        public ActionResult Put([FromBody] Session session)
        {
            if (SessionDAO.Put(session))
            {
                return Ok();
            }

            return BadRequest();
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (SessionDAO.Delete(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}