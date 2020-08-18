namespace TeamSourceControlDemo
{
    partial class ShowRecipeForm
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
            this.IngredientsTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ServingsTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RecipeTitleTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InstructionsTxt = new System.Windows.Forms.TextBox();
            this.PrepTimeTxt = new System.Windows.Forms.TextBox();
            this.TotalTimeTxt = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IngredientsTxt
            // 
            this.IngredientsTxt.Enabled = false;
            this.IngredientsTxt.Location = new System.Drawing.Point(312, 17);
            this.IngredientsTxt.Multiline = true;
            this.IngredientsTxt.Name = "IngredientsTxt";
            this.IngredientsTxt.Size = new System.Drawing.Size(112, 158);
            this.IngredientsTxt.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ingredients";
            // 
            // ServingsTxt
            // 
            this.ServingsTxt.Enabled = false;
            this.ServingsTxt.Location = new System.Drawing.Point(114, 127);
            this.ServingsTxt.Name = "ServingsTxt";
            this.ServingsTxt.Size = new System.Drawing.Size(100, 20);
            this.ServingsTxt.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Time";
            // 
            // RecipeTitleTxt
            // 
            this.RecipeTitleTxt.Enabled = false;
            this.RecipeTitleTxt.Location = new System.Drawing.Point(114, 17);
            this.RecipeTitleTxt.Name = "RecipeTitleTxt";
            this.RecipeTitleTxt.Size = new System.Drawing.Size(100, 20);
            this.RecipeTitleTxt.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Recipe Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Instructions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "PrepTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Servings Made";
            // 
            // InstructionsTxt
            // 
            this.InstructionsTxt.Enabled = false;
            this.InstructionsTxt.Location = new System.Drawing.Point(17, 187);
            this.InstructionsTxt.Multiline = true;
            this.InstructionsTxt.Name = "InstructionsTxt";
            this.InstructionsTxt.Size = new System.Drawing.Size(407, 101);
            this.InstructionsTxt.TabIndex = 26;
            // 
            // PrepTimeTxt
            // 
            this.PrepTimeTxt.Enabled = false;
            this.PrepTimeTxt.Location = new System.Drawing.Point(114, 87);
            this.PrepTimeTxt.Name = "PrepTimeTxt";
            this.PrepTimeTxt.Size = new System.Drawing.Size(100, 20);
            this.PrepTimeTxt.TabIndex = 20;
            // 
            // TotalTimeTxt
            // 
            this.TotalTimeTxt.Enabled = false;
            this.TotalTimeTxt.Location = new System.Drawing.Point(114, 52);
            this.TotalTimeTxt.Name = "TotalTimeTxt";
            this.TotalTimeTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalTimeTxt.TabIndex = 18;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(281, 304);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(143, 37);
            this.closeBtn.TabIndex = 27;
            this.closeBtn.Text = "Exit";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ShowRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 353);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.IngredientsTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ServingsTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RecipeTitleTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InstructionsTxt);
            this.Controls.Add(this.PrepTimeTxt);
            this.Controls.Add(this.TotalTimeTxt);
            this.Name = "ShowRecipeForm";
            this.Text = "ShowRecipeForm";
            this.Load += new System.EventHandler(this.ShowRecipeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IngredientsTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ServingsTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RecipeTitleTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InstructionsTxt;
        private System.Windows.Forms.TextBox PrepTimeTxt;
        private System.Windows.Forms.TextBox TotalTimeTxt;
        private System.Windows.Forms.Button closeBtn;
    }
}