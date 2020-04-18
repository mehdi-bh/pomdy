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
        [HttpGet]
        public ActionResult<IEnumerable<Extrabreak>> GetAll()
        {
            return Ok(ExtrabreakDAO.GetAll());
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
    }
}