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
        
        public static Recipe Update(Recipe r)
        {
            throw new NotImplementedException();
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
