using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pomdyBackend.DAO;
using pomdyBackend.Model;

namespace pomdyBackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ExtrabreaksController : ControllerBase
    {
        /***** API Extrabreaks *****/
        [HttpGet]
        public ActionResult<IEnumerable<Extrabreak>> GetAll()
        {
            return Ok(ExtrabreakDAO.GetAll());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Extrabreak> Get(int id)
        {
            Extrabreak extrabreak = ExtrabreakDAO.Get(id);

            return extrabreak != null ? (ActionResult<Extrabreak>) Ok(extrabreak) : NotFound("This extrabreak doesn't exist!");
        }
        
        [HttpPost]
        public ActionResult<Extrabreak> Post([FromBody] Extrabreak extrabreak)
        {
            return Ok(ExtrabreakDAO.Post(extrabreak));
        }
        
        [HttpPut]
        public ActionResult Put([FromBody] Extrabreak extrabreak)
        {
            if (ExtrabreakDAO.Put(extrabreak))
            {
                return Ok();
            }

            return BadRequest();
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (ExtrabreakDAO.Delete(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}