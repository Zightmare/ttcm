using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ttcm_api.Models;

namespace ttcm_api.Controllers
{
    // /api/enrollments
    [Route("api/enrollments")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        public static List<Enrollment> Enrollments = new List<Enrollment>();

        [HttpGet]
        public IActionResult GetEnrollments()
        {
            return Ok(Enrollments);
        }

        [HttpPost]
        public IActionResult CreateEnrollment([FromBody] Enrollment enrollment)
        {
            Enrollments.Add(enrollment);
            return CreatedAtAction("CreateEnrollment", new { Id = enrollment.Id }, enrollment);
        }

        [HttpGet("{id}")]
        public IActionResult GetEnrollment(int id)
        {
            var foundEnrollment = Enrollments.FirstOrDefault(e => e.Id == id);
            if (foundEnrollment == null)
                return NotFound("Enrollment Not Found!");
            return Ok(foundEnrollment);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEnrollment(int id, [FromBody] Enrollment updatedEnrollment)
        {
            var existingEnrollment = Enrollments.FirstOrDefault(e => e.Id == id);
            if (existingEnrollment == null)
                return NotFound("Enrollment Not Found!");

            existingEnrollment.TraineeId = updatedEnrollment.TraineeId;
            existingEnrollment.CourseId = updatedEnrollment.CourseId;
            existingEnrollment.EnrollmentDate = updatedEnrollment.EnrollmentDate;

            return Ok(existingEnrollment);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEnrollment(int id)
        {
            var enrollment = Enrollments.FirstOrDefault(e => e.Id == id);
            if (enrollment == null)
                return NotFound("Enrollment Not Found!");

            Enrollments.Remove(enrollment);
            return NoContent();
        }
    }
}
