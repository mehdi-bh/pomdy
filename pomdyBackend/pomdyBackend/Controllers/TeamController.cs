using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pomdyBackend.DAO;
using pomdyBackend.Model;

namespace pomdyBackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TeamsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Team>> GetAll()
        {
            return Ok(TeamDAO.GetAll());
        }
        
        [HttpPost]
        public ActionResult<Team> Post([FromBody] Team team)
        {
            // TODO : check doublon (nom)
            return Ok(TeamDAO.Post(team));
        }
        
        [HttpPut]
        public ActionResult Put([FromBody] Team team)
        {
            if (TeamDAO.Put(team))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}