﻿namespace ttcm_api.Models
{
    public class Trainer:User
    {
        //public int Id { get; set; }
        //public string UserId { get; set; } // FK to ApplicationUser
        public decimal Salary { get; set; }
        public string Specialization { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

    }
}
