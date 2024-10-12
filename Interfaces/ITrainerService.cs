using ttcm_api.Models;

namespace ttcm_api.Interfaces
{
    public interface ITrainerService
    {
        List<Trainer> GetAll();
        Trainer GetById(int id);
        void Add(Trainer trainer);
        void Update(int id, Trainer updatedTrainer);
        void Delete(int id);
    }


}
