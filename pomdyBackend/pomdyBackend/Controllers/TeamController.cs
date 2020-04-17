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
    }
}