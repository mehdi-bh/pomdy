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
        /***** API Team *****/
        [HttpGet]
        public ActionResult<IEnumerable<Team>> GetAll()
        {
            return Ok(TeamDAO.GetAll());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Team> Get(int id)
        {
            Team team = TeamDAO.Get(id);

            return team != null ? (ActionResult<Team>) Ok(team) : NotFound("This team doesn't exist!");
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
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (TeamDAO.Delete(id))
            {
                return Ok();
            }
            return BadRequest();
        }
        
        /***** API TeamStudent *****/
        [HttpGet("{id}/students")]
        public ActionResult<IEnumerable<Student>> GetTeamStudents(int id)
        {
            return Ok(TeamStudentDAO.GetTeamStudents(id));
        }
        
        [HttpPost("{idTeam}/students")]
        public ActionResult<TeamStudent> Post(int idTeam,[FromBody] Student student)
        {
            // TODO : check doublon si student déjà dans la team
            TeamStudent teamStudent = new TeamStudent(idTeam,student.Id);
            if (TeamStudentDAO.Post(teamStudent))
            {
                return Ok();
            }
            return BadRequest();
        }
        
        [HttpDelete("{idTeam}/students")]
        public ActionResult<TeamStudent> Delete(int idTeam,[FromBody] Student student)
        {
            TeamStudent teamStudent = new TeamStudent(idTeam,student.Id);
            if (TeamStudentDAO.Delete(teamStudent))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}