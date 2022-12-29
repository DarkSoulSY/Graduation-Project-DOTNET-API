using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness_Application.Models.Enum;

namespace Fitness_Application.Models
{
    public class Preferences
    {
        public int Id { get; set; }
        public ObjectivePlan Plan { get; set; }
        public float Weight_Goal { get; set; } //Goal in Kilograms
        public BaselineActivity Baseline_Activity { get; set; }
        public float Weekly_Goal {get; set;}
        
        public Account? Account { get; set; }
        public int AccountId { get; set; }

    }
}