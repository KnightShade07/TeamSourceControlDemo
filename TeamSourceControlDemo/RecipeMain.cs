using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControlDemo
{
    public partial class RecipeMain : Form
    {
        public static int currRecipeId;
        public RecipeMain()
        {
            InitializeComponent();
        }private void RecipeMain_Load(object sender, EventArgs e)
        {
            List<Recipe> allRecipes = RecipeDb.GetAllRecipes();
            PopulateRecipeList(allRecipes);
        }
        /// <summary>
        /// Populates the Combo Box with the
        /// Recipe names from the RecipeDB.
        /// </summary>
        /// <param name="recipes">The list of recipes</param>
        private void PopulateRecipeList(List<Recipe> recipes)
        {
            RecipeCbx.DataSource = recipes;
            RecipeCbx.DisplayMember = nameof(Recipe.Title);
        }
        
        /// <summary>
        /// When the Add Recipe Button is clicked, it will
        /// display the AddRecipe Form.
        /// </summary>
        
        private void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            Form1 addForm = new Form1();
            addForm.Show();
        }
        /// <summary>
        /// Closes the form when clicked.
        /// </summary>
        

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Shows the Edit/Delete Form when a user
        /// clicks the Edit/Delete Recipe Button.
        /// </summary>
        
        private void EditDeleteRecipeBtn_Click(object sender, EventArgs e)
        {
            // gets item selected in the combo box
            GetRecipeId();
            EditDeleteForm form = new EditDeleteForm();
            form.Show();
            //Updates Recipe List.
            
        }
        private void showRecipeBtn_Click_1(object sender, EventArgs e)
        {
            GetRecipeId();
            ShowRecipeForm newForm = new ShowRecipeForm();
            newForm.Show();
        }
        /// <summary>
        /// Gets the current recipeId
        /// </summary>
        private void GetRecipeId()
        {
            Recipe currRecipe = RecipeCbx.SelectedItem as Recipe;
            currRecipeId = currRecipe.RecipeId;
        }
        /// <summary>
        /// Refreshes the recipe combo box after the recipe has been added/deleted.
        /// </summary>
        
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            List<Recipe> allRecipes = RecipeDb.GetAllRecipes();
            PopulateRecipeList(allRecipes);
        }
    }
}
