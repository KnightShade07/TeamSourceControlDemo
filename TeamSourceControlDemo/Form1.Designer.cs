namespace TeamSourceControlDemo
{
    partial class Form1
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
            this.TotalTimeTxt = new System.Windows.Forms.TextBox();
            this.PrepTimeTxt = new System.Windows.Forms.TextBox();
            this.InstructionsTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddRecipeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RecipeTitleTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ServingsTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IngredientsTxt = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalTimeTxt
            // 
            this.TotalTimeTxt.Location = new System.Drawing.Point(112, 128);
            this.TotalTimeTxt.Name = "TotalTimeTxt";
            this.TotalTimeTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalTimeTxt.TabIndex = 6;
            // 
            // PrepTimeTxt
            // 
            this.PrepTimeTxt.Location = new System.Drawing.Point(112, 163);
            this.PrepTimeTxt.Name = "PrepTimeTxt";
            this.PrepTimeTxt.Size = new System.Drawing.Size(100, 20);
            this.PrepTimeTxt.TabIndex = 8;
            // 
            // InstructionsTxt
            // 
            this.InstructionsTxt.Location = new System.Drawing.Point(359, 118);
            this.InstructionsTxt.Multiline = true;
            this.InstructionsTxt.Name = "InstructionsTxt";
            this.InstructionsTxt.Size = new System.Drawing.Size(191, 101);
            this.InstructionsTxt.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Servings Made";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PrepTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Instructions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Recipe";
            // 
            // AddRecipeBtn
            // 
            this.AddRecipeBtn.Location = new System.Drawing.Point(89, 276);
            this.AddRecipeBtn.Name = "AddRecipeBtn";
            this.AddRecipeBtn.Size = new System.Drawing.Size(123, 47);
            this.AddRecipeBtn.TabIndex = 15;
            this.AddRecipeBtn.Text = "Add Recipe To Database!";
            this.AddRecipeBtn.UseVisualStyleBackColor = true;
            this.AddRecipeBtn.Click += new System.EventHandler(this.AddRecipeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Recipe Name";
            // 
            // RecipeTitleTxt
            // 
            this.RecipeTitleTxt.Location = new System.Drawing.Point(112, 93);
            this.RecipeTitleTxt.Name = "RecipeTitleTxt";
            this.RecipeTitleTxt.Size = new System.Drawing.Size(100, 20);
            this.RecipeTitleTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Time";
            // 
            // ServingsTxt
            // 
            this.ServingsTxt.Location = new System.Drawing.Point(112, 203);
            this.ServingsTxt.Name = "ServingsTxt";
            this.ServingsTxt.Size = new System.Drawing.Size(100, 20);
            this.ServingsTxt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingredients";
            // 
            // IngredientsTxt
            // 
            this.IngredientsTxt.Location = new System.Drawing.Point(245, 118);
            this.IngredientsTxt.Multiline = true;
            this.IngredientsTxt.Name = "IngredientsTxt";
            this.IngredientsTxt.Size = new System.Drawing.Size(100, 154);
            this.IngredientsTxt.TabIndex = 12;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(450, 278);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 45);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Close";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 405);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.IngredientsTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ServingsTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RecipeTitleTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddRecipeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InstructionsTxt);
            this.Controls.Add(this.PrepTimeTxt);
            this.Controls.Add(this.TotalTimeTxt);
            this.Name = "Form1";
            this.Text = "Add Recipe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotalTimeTxt;
        private System.Windows.Forms.TextBox PrepTimeTxt;
        private System.Windows.Forms.TextBox InstructionsTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddRecipeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RecipeTitleTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ServingsTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IngredientsTxt;
        private System.Windows.Forms.Button exitBtn;
    }
}

