﻿namespace InsuranceCompany.Forms
{
    partial class FormAddNewCategory
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
            this.labelCategory = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 22);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Категория";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(79, 74);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 24);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(121, 19);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategory.TabIndex = 3;
            // 
            // FormAddNewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 107);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddNewCategory";
            this.Text = "FormAddNewCategoryes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCategory;
    }
}