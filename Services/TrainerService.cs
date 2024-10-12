using ttcm_api.Interfaces;
using ttcm_api.Models;

public class TrainerService : ITrainerService
{
    private List<Trainer> trainers = new List<Trainer>();

    public List<Trainer> GetAll() => trainers;

    public Trainer GetById(int id) => trainers.FirstOrDefault(t => t.Id == id);

    public void Add(Trainer trainer)
    {
        trainer.Id = trainers.Count + 1;
        trainers.Add(trainer);
    }

    public void Update(int id, Trainer updatedTrainer)
    {
        var trainer = GetById(id);
        if (trainer != null)
        {
            trainer.Name = updatedTrainer.Name;
            trainer.Specialization = updatedTrainer.Specialization;
            trainer.Salary = updatedTrainer.Salary;
        }
    }

    public void Delete(int id)
    {
        var trainer = GetById(id);
        if (trainer != null)
        {
            trainers.Remove(trainer);
        }
    }
}

