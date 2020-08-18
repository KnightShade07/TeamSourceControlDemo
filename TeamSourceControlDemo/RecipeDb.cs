using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControlDemo
{
    static class RecipeDb
    {
        /// <summary>
        /// Gets all recipies from the database.
        /// </summary>
        /// <returns>The object containing all the recipies.</returns>
        public static List<Recipe> GetAllRecipes()
        {
            using (RecipeContext context = new RecipeContext())
            {
                // Returns all recipes from Db in a list.
                List<Recipe> allRecipes = context.Recipes.ToList();

                return allRecipes;
            }
        }
        /// <summary>
        /// Gets a specific recipe from the database.
        /// </summary>
        /// <param name="id">The ID number a recipe is assigned</param>
        /// <returns> getRec - The object holding the recipe data</returns>
        public static Recipe GetRecipe(int id)
        {
            using (RecipeContext context = new RecipeContext())
            {
                Recipe getRec =
                    (from r in context.Recipes
                     where r.RecipeId == id
                     select r).Single();

                return getRec;
            }
        }
        /// <summary>
        /// Adds recipe to the database. Returns the recipe with the <see cref="Recipe.RecipeId"/> property populated.
        /// </summary>
        /// <param name="r">The recipe to be added.</param>
        public static Recipe Add(Recipe r)
        {
            using (RecipeContext context = new RecipeContext())
            {
                context.Recipes.Add(r);
                context.SaveChanges();
                return r;

            }
        }
        /// <summary>
        /// Updates a recipe in the database.
        /// </summary>
        /// <param name="r">The object that contains the recipe data.</param>
        /// <returns>r</returns>
        public static Recipe Update(Recipe r)
        {
            using (RecipeContext updateContext = new RecipeContext())
            {
                //Write output to console.
                updateContext.Database.Log = Console.WriteLine;
                //Tells the EF that the object's data has been updated/modified in
                //some way
                updateContext.Entry(r).State = EntityState.Modified;
                //Executes Update Query
                updateContext.SaveChanges();
                return r;
            }
            
        }
        /// <summary>
        /// This method will delete a recipe from the database.
        /// </summary>
        /// <param name="r"> r - The object containing the recipe data.</param>
        public static void Delete(Recipe r)
        {
            using (RecipeContext context = new RecipeContext())
            {
                // Write EF output to the console
                context.Database.Log = Console.WriteLine;

                // Telling EF that the product is already in the DB and it should be deleted
                context.Entry(r).State = EntityState.Deleted;

                // Executes Delete query
                context.SaveChanges();
            }
        }
    }
}
