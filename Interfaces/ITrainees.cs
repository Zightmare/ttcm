using ttcm_api.Models;

namespace ttcm_api.Interfaces
{
    public interface ITraineeService 
    {
        List<Trainee> GetAll();
        Trainee GetById(int id);
        void Add(Trainee trainee);
        void Update(int id, Trainee updatedTrainee);
        void Delete(int id);
    }
}
