using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ttcm_api.Models;

namespace ttcm_api.Controllers
{
    // /api/trainees
    [Route("api/trainees")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        public static List<Trainee> Trainees = new List<Trainee>();

        [HttpGet]
        public IActionResult GetTrainees()
        {
            return Ok(Trainees);
        }

        [HttpPost]
        public IActionResult CreateTrainee([FromBody] Trainee t)
        {
            Trainees.Add(t);
            return CreatedAtAction("CreateTrainee", new { Id = t.Id }, t);
        }

        [HttpGet("{id}")]
        public IActionResult GetTrainee(int id)
        {
            var foundTrainee = Trainees.FirstOrDefault(t => t.Id == id);
            if (foundTrainee == null)
                return NotFound("Trainee Not Found!");
            return Ok(foundTrainee);
        }
    }
}
