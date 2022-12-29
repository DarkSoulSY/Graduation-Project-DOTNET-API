using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness_Application.Models
{
    public class FoodProduct
    {
        public int Id { get; set; }
        public string Product_Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public int Total_Fat { get; set; }
        public int Saturated { get; set; }
        public int Trans { get; set; }
        public int Polyunsaturated { get; set; }
        public int Monounsaturated { get; set; }
        public int Cholesterol { get; set; }
        public int Sodium { get; set; }
        public int Total_Carbohydrates { get; set; }
        public int Dietary_Fiber { get; set; }
        public int Sugar { get; set; }
        public int Added_Sugar { get; set; }
        public int Sugar_Alcohols { get; set; }
        public int Protein { get; set; }
        public int Vitamin_D { get; set; }
        public int Calcium { get; set; }
        public int Iron { get; set; }
        public int Vitamin_A { get; set; }
        public int Vitamin_C { get; set; }
        public List<Diary>? Diary { get; set; }
    }
}