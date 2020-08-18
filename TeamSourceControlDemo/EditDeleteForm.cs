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
    public partial class EditDeleteForm : Form
    {
        public int CurrRecipeId { get; set; }
        
        public EditDeleteForm()
        {
            InitializeComponent();
        }

        public EditDeleteForm(int id)
        {
            InitializeComponent();
            CurrRecipeId = id;
        }

        private void EditDeleteForm_Load(object sender, EventArgs e)
        {
            CurrRecipeId = RecipeMain.currRecipeId;
            Recipe currRecipe = RecipeDb.GetRecipe(CurrRecipeId);
            PopulateCurrentRecipe(currRecipe);
        }

        private void PopulateCurrentRecipe(Recipe r)
        {
            RecipeTitleTxt.Text = r.Title;
            TotalTimeTxt.Text = r.TotalTime.ToString();
            PrepTimeTxt.Text = r.PrepTime.ToString();
            ServingsTxt.Text = r.Servings.ToString();
            IngredientsTxt.Text = r.Ingredients.ToString();
            InstructionsTxt.Text = r.Instructions.ToString();
            
        private void EditBtn_Click(object sender, EventArgs e)
        {
            //This is where we'll call our Update Method in RecipeDB
            
        }
    }
}
