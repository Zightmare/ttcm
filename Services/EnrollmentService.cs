using ttcm_api.Interfaces;
using ttcm_api.Models;

public class EnrollmentService : IEnrollmentService
{
    private List<Enrollment> enrollments = new List<Enrollment>();

    public List<Enrollment> GetAll() => enrollments;

    public Enrollment GetById(int id) => enrollments.FirstOrDefault(e => e.Id == id);

    public void Add(Enrollment enrollment)
    {
        enrollment.Id = enrollments.Count + 1;
        enrollments.Add(enrollment);
    }

    public void Update(int id, Enrollment updatedEnrollment)
    {
        var enrollment = GetById(id);
        if (enrollment != null)
        {
            enrollment.TraineeId = updatedEnrollment.TraineeId;
            enrollment.CourseId = updatedEnrollment.CourseId;
            enrollment.EnrollmentDate = updatedEnrollment.EnrollmentDate;
        }
    }

    public void Delete(int id)
    {
        var enrollment = GetById(id);
        if (enrollment != null)
        {
            enrollments.Remove(enrollment);
        }
    }
}
