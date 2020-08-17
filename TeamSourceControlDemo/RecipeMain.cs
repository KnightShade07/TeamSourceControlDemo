using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TeamSourceControlDemo
{
    public partial class RecipeMain : Form
    {
        public RecipeMain()
        {
            InitializeComponent();
        }

        private void RecipeMain_Load(object sender, EventArgs e)
        {
            List<Recipe> allRecipes = RecipeDb.GetAllRecipes();
            PopulateRecipeList(allRecipes);
        }
        private void PopulateRecipeList(List<Recipe> recipes)
        {
            RecipeCbx.Items.Clear();
            foreach (Recipe r in recipes)
            {
                RecipeCbx.Items.Add(r.Title);
            }
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
            EditDeletForm newform = new EditDeletForm();
            newform.Show();
        }

    }
}
