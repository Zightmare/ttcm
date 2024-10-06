﻿namespace ttcm_api.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Admin", "Trainer", "Trainee"
    }

}