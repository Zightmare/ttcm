using ttcm_api.Models;

namespace ttcm_api.Interfaces
{
    public interface IEnrollmentService
    {
        List<Enrollment> GetAll();
        Enrollment GetById(int id);
        void Add(Enrollment enrollment);
        void Update(int id, Enrollment updatedEnrollment);
        void Delete(int id);
    }
}
