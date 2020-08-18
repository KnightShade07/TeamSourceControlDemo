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
            Recipe currRecipe = RecipeCbx.SelectedItem as Recipe;
            // stores id of the current recipe into the global variable to be passed to the new form
            currRecipeId = currRecipe.RecipeId;
            if (RecipeDb.GetRecipe(currRecipe.RecipeId) != null)
            {
                using (EditDeleteForm form = new EditDeleteForm())
                {
                    form.ShowDialog();
                }
            }
        }

        private void showRecipeBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
