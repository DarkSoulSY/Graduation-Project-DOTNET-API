using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness_Application.Models.Enum;

namespace Fitness_Application.Models
{
    public class Diary
    {
        public int Id { get; set; }
        public DateTime DailyDate { get; set; }
        public float Burned_Calories { get; set; }
        public float Consumed_Calories { get; set; }
        public float Current_Weight { get; set; }
        public Account? Account { get; set; }
        [NotMapped]
        public ProductImage? Current_Weight_Image { get; set; }
        public MealType? Meal_Type { get; set; } 
        public List<FoodProduct>? Food_Product { get; set; }

    }
}