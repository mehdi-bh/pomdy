using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pomdyBackend.DAO;
using pomdyBackend.Model;

namespace pomdyBackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetAll()
        {
            return Ok(ProjectDAO.GetAll());
        }
    }
}