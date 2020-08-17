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
        public RecipeMain()
        {
            InitializeComponent();
        }

        private void RecipeMain_Load(object sender, EventArgs e)
        {
        }
        private void RecipeCatalogCbx(object sender, EventArgs e)
        {

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
