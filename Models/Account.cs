using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness_Application.Models.Enum;

namespace Fitness_Application.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string email { get; set; } = string.Empty;
        public string First_Name { get; set; } = string.Empty;
        public string Last_Name { get; set; } = string.Empty;
        public float Height { get; set; }
        public static float Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Phone_Number { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
        public Preferences? Account_Preferences { get; set; }
        
    }
}