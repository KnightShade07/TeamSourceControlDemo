﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //closes the form.
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            CurrRecipeId = RecipeMain.currRecipeId;
            Recipe currRecipe = RecipeDb.GetRecipe(CurrRecipeId);

            const string message = "Do you want to delete this recipe?";
            var caption = "Delete?";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                RecipeDb.Delete(currRecipe);
                Close();
            }

            
        }
        /// <summary>
        /// When the user clicks this button, the recipe in the
        /// database gets updated with the new information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Recipe tempRecipe = new Recipe();
            tempRecipe.RecipeId = CurrRecipeId;
            tempRecipe.Title = RecipeTitleTxt.Text;
            tempRecipe.TotalTime = Convert.ToInt32(TotalTimeTxt.Text);
            tempRecipe.PrepTime = Convert.ToInt32(TotalTimeTxt.Text);
            tempRecipe.Servings = Convert.ToInt32(ServingsTxt.Text);
            tempRecipe.Ingredients = IngredientsTxt.Text;
            tempRecipe.Instructions = InstructionsTxt.Text;
            RecipeDb.Update(tempRecipe);
            MessageBox.Show(tempRecipe.Title + " was updated!");
            
        }
    }
}