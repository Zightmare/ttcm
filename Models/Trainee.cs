namespace ttcm_api.Models
{
    public class Trainee:User
    {
        public decimal Salary { get; set; }
        public string Specialization { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public bool IsGraduated { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
