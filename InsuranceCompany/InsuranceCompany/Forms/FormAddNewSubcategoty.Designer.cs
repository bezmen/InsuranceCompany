﻿namespace InsuranceCompany.Forms
{
    partial class FormAddNewSubcategoty
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxInsuranceCase = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelInsuranceCase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(135, 19);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(112, 141);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxInsuranceCase
            // 
            this.textBoxInsuranceCase.Location = new System.Drawing.Point(135, 66);
            this.textBoxInsuranceCase.Name = "textBoxInsuranceCase";
            this.textBoxInsuranceCase.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsuranceCase.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(16, 19);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Категория";
            // 
            // labelInsuranceCase
            // 
            this.labelInsuranceCase.AutoSize = true;
            this.labelInsuranceCase.Location = new System.Drawing.Point(16, 69);
            this.labelInsuranceCase.Name = "labelInsuranceCase";
            this.labelInsuranceCase.Size = new System.Drawing.Size(97, 13);
            this.labelInsuranceCase.TabIndex = 4;
            this.labelInsuranceCase.Text = "Страховой случай";
            // 
            // FormAddNewSubcategoty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 186);
            this.Controls.Add(this.labelInsuranceCase);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxInsuranceCase);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "FormAddNewSubcategoty";
            this.Text = "FormAddNewSubcategoty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxInsuranceCase;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelInsuranceCase;
    }
}