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
        public static List<Recipe> GetAllRecipes()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Adds recipe to the database. Returns the recipe with the <see cref="Recipe.RecipeId"/> property populated
        /// </summary>
        /// <param name="r">The recipe to be added</param>
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
        /// <param name="r">The object that contains the recipe data</param>
        /// <returns></returns>
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
