namespace TeamSourceControlDemo
{
    partial class RecipeMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecipeCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddRecipeBtn = new System.Windows.Forms.Button();
            this.EditDeleteRecipeBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.showRecipeBtn = new System.Windows.Forms.Button();
            this.mainPagelbl = new System.Windows.Forms.Label();
            this.showAllRecipiesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecipeCbx
            // 
            this.RecipeCbx.FormattingEnabled = true;
            this.RecipeCbx.Location = new System.Drawing.Point(12, 44);
            this.RecipeCbx.Name = "RecipeCbx";
            this.RecipeCbx.Size = new System.Drawing.Size(170, 21);
            this.RecipeCbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipe Catalog";
            // 
            // AddRecipeBtn
            // 
            this.AddRecipeBtn.Location = new System.Drawing.Point(12, 107);
            this.AddRecipeBtn.Name = "AddRecipeBtn";
            this.AddRecipeBtn.Size = new System.Drawing.Size(100, 40);
            this.AddRecipeBtn.TabIndex = 2;
            this.AddRecipeBtn.Text = "Add Recipe";
            this.AddRecipeBtn.UseVisualStyleBackColor = true;
            this.AddRecipeBtn.Click += new System.EventHandler(this.AddRecipeBtn_Click);
            // 
            // EditDeleteRecipeBtn
            // 
            this.EditDeleteRecipeBtn.Location = new System.Drawing.Point(122, 107);
            this.EditDeleteRecipeBtn.Name = "EditDeleteRecipeBtn";
            this.EditDeleteRecipeBtn.Size = new System.Drawing.Size(100, 40);
            this.EditDeleteRecipeBtn.TabIndex = 3;
            this.EditDeleteRecipeBtn.Text = "Edit/Delete Recipe";
            this.EditDeleteRecipeBtn.UseVisualStyleBackColor = true;
            this.EditDeleteRecipeBtn.Click += new System.EventHandler(this.EditDeleteRecipeBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(228, 107);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 40);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // showRecipeBtn
            // 
            this.showRecipeBtn.Location = new System.Drawing.Point(203, 42);
            this.showRecipeBtn.Name = "showRecipeBtn";
            this.showRecipeBtn.Size = new System.Drawing.Size(125, 23);
            this.showRecipeBtn.TabIndex = 5;
            this.showRecipeBtn.Text = "Show Recipe";
            this.showRecipeBtn.UseVisualStyleBackColor = true;
            this.showRecipeBtn.Click += new System.EventHandler(this.showRecipeBtn_Click_1);
            // 
            // mainPagelbl
            // 
            this.mainPagelbl.AutoSize = true;
            this.mainPagelbl.Location = new System.Drawing.Point(155, 13);
            this.mainPagelbl.Name = "mainPagelbl";
            this.mainPagelbl.Size = new System.Drawing.Size(58, 13);
            this.mainPagelbl.TabIndex = 6;
            this.mainPagelbl.Text = "Main Page";
            // 
            // showAllRecipiesButton
            // 
            this.showAllRecipiesButton.Location = new System.Drawing.Point(203, 78);
            this.showAllRecipiesButton.Name = "showAllRecipiesButton";
            this.showAllRecipiesButton.Size = new System.Drawing.Size(125, 23);
            this.showAllRecipiesButton.TabIndex = 7;
            this.showAllRecipiesButton.Text = "Show All Recipies";
            this.showAllRecipiesButton.UseVisualStyleBackColor = true;
            this.showAllRecipiesButton.Click += new System.EventHandler(this.showAllRecipiesButton_Click);
            // 
            // RecipeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 168);
            this.Controls.Add(this.showAllRecipiesButton);
            this.Controls.Add(this.mainPagelbl);
            this.Controls.Add(this.showRecipeBtn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.EditDeleteRecipeBtn);
            this.Controls.Add(this.AddRecipeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecipeCbx);
            this.Name = "RecipeMain";
            this.Text = "Recipe Catalog";
            this.Load += new System.EventHandler(this.RecipeMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RecipeCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddRecipeBtn;
        private System.Windows.Forms.Button EditDeleteRecipeBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button showRecipeBtn;
        private System.Windows.Forms.Label mainPagelbl;
        private System.Windows.Forms.Button showAllRecipiesButton;
    }
}