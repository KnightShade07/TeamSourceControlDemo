using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControlDemo
{
    class Recipe
    {
        /// <summary>
        /// The Id of the recipe in the database
        /// </summary>
        public int RecipeId { get; set; }
        /// <summary>
        /// The name of the recipe
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The total amount of time from start to completion of the recipe
        /// </summary>
        public int TotalTime { get; set; }
        /// <summary>
        /// The amount to time to prep the ingredients for the recipe
        /// </summary>
        public int PrepTime { get; set; }
        /// <summary>
        /// The amount of servings the recipe makes
        /// </summary>
        public int Servings { get; set; }
        /// <summary>
        /// A list of ingredients needed for the recipe
        /// </summary>
        public string Ingredients { get; set; }
        /// <summary>
        /// Instructions on how to make the food
        /// </summary>
        public string Instructions { get; set; }
    }
}
