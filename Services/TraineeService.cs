using ttcm_api.Interfaces;
using ttcm_api.Models;

public class TraineeService : ITraineeService
{
    private List<Trainee> trainees = new List<Trainee>();

    public List<Trainee> GetAll() => trainees;

    public Trainee GetById(int id) => trainees.FirstOrDefault(t => t.Id == id);

    public void Add(Trainee trainee)
    {
        trainee.Id = trainees.Count + 1;
        trainees.Add(trainee);
    }

    public void Update(int id, Trainee updatedTrainee)
    {
        var trainee = GetById(id);
        if (trainee != null)
        {
            trainee.Name = updatedTrainee.Name;

        }
    }

    public void Delete(int id)
    {
        var trainee = GetById(id);
        if (trainee != null)
        {
            trainees.Remove(trainee);
        }
    }
}
