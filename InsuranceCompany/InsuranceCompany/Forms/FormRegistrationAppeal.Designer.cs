namespace InsuranceCompany.Forms
{
    partial class FormRegistrationAppeal
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
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelSubcategory = new System.Windows.Forms.Label();
            this.comboBoxSubcategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(84, 124);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistration.TabIndex = 0;
            this.buttonRegistration.Text = "Оформить";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(8, 15);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Клиент";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(109, 12);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 2;
            this.comboBoxClient.SelectedValueChanged += new System.EventHandler(this.comboBoxClient_SelectedValueChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(8, 46);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(63, 13);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "Категория ";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(109, 43);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 5;
            this.comboBoxCategory.SelectedValueChanged += new System.EventHandler(this.comboBoxСategory_SelectedValueChanged);
            // 
            // labelSubcategory
            // 
            this.labelSubcategory.AutoSize = true;
            this.labelSubcategory.Location = new System.Drawing.Point(8, 77);
            this.labelSubcategory.Name = "labelSubcategory";
            this.labelSubcategory.Size = new System.Drawing.Size(97, 13);
            this.labelSubcategory.TabIndex = 6;
            this.labelSubcategory.Text = "Страховой случай";
            // 
            // comboBoxSubcategory
            // 
            this.comboBoxSubcategory.FormattingEnabled = true;
            this.comboBoxSubcategory.Location = new System.Drawing.Point(109, 74);
            this.comboBoxSubcategory.Name = "comboBoxSubcategory";
            this.comboBoxSubcategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubcategory.TabIndex = 7;
            // 
            // FormRegistrationAppeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 168);
            this.Controls.Add(this.comboBoxSubcategory);
            this.Controls.Add(this.labelSubcategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.buttonRegistration);
            this.Name = "FormRegistrationAppeal";
            this.Text = "FormRegistrationAppeal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelSubcategory;
        private System.Windows.Forms.ComboBox comboBoxSubcategory;
    }
}