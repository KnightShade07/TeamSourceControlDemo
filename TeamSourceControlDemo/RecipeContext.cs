namespace TeamSourceControlDemo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RecipeContext : DbContext
    {
        // Your context has been configured to use a 'RecipeContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TeamSourceControlDemo.RecipeContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RecipeContext' 
        // connection string in the application configuration file.
        public RecipeContext()
            : base("name=RecipeContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
    }
}