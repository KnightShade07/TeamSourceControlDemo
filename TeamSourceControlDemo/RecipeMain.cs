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
        private void PopulateRecipeList(List<Recipe> recipes)
        {
            RecipeCbx.DataSource = recipes;
            RecipeCbx.DisplayMember = nameof(Recipe.Title);
        }
        /// <summary>
        /// Refreshes the combo box after updating without closing
        /// the application.
        /// </summary>
        public static void RefreshRecipeList()
        {
            
            List<Recipe> allRecipes = RecipeDb.GetAllRecipes();
            RecipeCbx.DataSource = allRecipes;
        }

        private void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            Form1 addForm = new Form1();
            addForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        // gets the id from the selected item in the combo box 
        private void GetRecipeId()
        {
            Recipe currRecipe = RecipeCbx.SelectedItem as Recipe;
            currRecipeId = currRecipe.RecipeId;
        }

        private void showAllRecipiesButton_Click(object sender, EventArgs e)
        {
            AllRecipesForm allRecipes = new AllRecipesForm();
            allRecipes.Show();
            
        }
    }
}
