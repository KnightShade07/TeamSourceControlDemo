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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method will add a recipe
        /// to the database when the "Add Recipe"
        /// button is clicked.
        /// </summary>
        private void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            Recipe r = new Recipe()
            {
                Title = RecipeTitleTxt.Text,
                TotalTime = Convert.ToInt32(TotalTimeTxt.Text),
                PrepTime = Convert.ToInt32(PrepTimeTxt.Text),
                Servings = Convert.ToInt32(ServingsTxt.Text),
                Ingredients = IngredientsTxt.Text,
                Instructions = InstructionsTxt.Text
            };

            RecipeContext dbContext = new RecipeContext();
            dbContext.Recipes.Add(r);
            dbContext.SaveChanges();
            ClearTextBoxes();
            MessageBox.Show(RecipeTitleTxt.Text + " has been added!");
        }
        /// <summary>
        /// Clears text all text boxes after submitting to the DB
        /// </summary>
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void UpdateRecipebtn_Click(object sender, EventArgs e)
        {
            updateRecipe();
        }

        public void updateRecipe()
        {
            //Load all recipies.
            List<Recipe> allRecipes = 
            //Clear old data.

            //and then replace old data with
            //new data.
        }
    }
}
