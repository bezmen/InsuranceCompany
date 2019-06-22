namespace InsuranceCompany.Forms
{
    partial class FormProcessingOfPayout
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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelAppeal = new System.Windows.Forms.Label();
            this.comboBoxAppeal = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelSubcategory = new System.Windows.Forms.Label();
            this.textBoxSubcategory = new System.Windows.Forms.TextBox();
            this.labelSumPayout = new System.Windows.Forms.Label();
            this.textBoxSumPayout = new System.Windows.Forms.TextBox();
            this.buttonDenied = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(15, 182);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(90, 23);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Подтвердить";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 21);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Клиент";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(84, 18);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(144, 21);
            this.comboBoxClient.TabIndex = 2;
            this.comboBoxClient.SelectedValueChanged += new System.EventHandler(this.comboBoxClient_SelectedValueChanged);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(84, 72);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(144, 20);
            this.textBoxCategory.TabIndex = 3;
            // 
            // labelAppeal
            // 
            this.labelAppeal.AutoSize = true;
            this.labelAppeal.Location = new System.Drawing.Point(12, 48);
            this.labelAppeal.Name = "labelAppeal";
            this.labelAppeal.Size = new System.Drawing.Size(66, 13);
            this.labelAppeal.TabIndex = 4;
            this.labelAppeal.Text = "Обращения";
            // 
            // comboBoxAppeal
            // 
            this.comboBoxAppeal.FormattingEnabled = true;
            this.comboBoxAppeal.Location = new System.Drawing.Point(84, 45);
            this.comboBoxAppeal.Name = "comboBoxAppeal";
            this.comboBoxAppeal.Size = new System.Drawing.Size(144, 21);
            this.comboBoxAppeal.TabIndex = 5;
            this.comboBoxAppeal.SelectedValueChanged += new System.EventHandler(this.comboBoxAppeal_SelectedValueChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 75);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Категория";
            // 
            // labelSubcategory
            // 
            this.labelSubcategory.AutoSize = true;
            this.labelSubcategory.Location = new System.Drawing.Point(12, 101);
            this.labelSubcategory.Name = "labelSubcategory";
            this.labelSubcategory.Size = new System.Drawing.Size(42, 13);
            this.labelSubcategory.TabIndex = 7;
            this.labelSubcategory.Text = "Случай";
            // 
            // textBoxSubcategory
            // 
            this.textBoxSubcategory.Location = new System.Drawing.Point(84, 98);
            this.textBoxSubcategory.Name = "textBoxSubcategory";
            this.textBoxSubcategory.Size = new System.Drawing.Size(144, 20);
            this.textBoxSubcategory.TabIndex = 8;
            // 
            // labelSumPayout
            // 
            this.labelSumPayout.AutoSize = true;
            this.labelSumPayout.Location = new System.Drawing.Point(12, 129);
            this.labelSumPayout.Name = "labelSumPayout";
            this.labelSumPayout.Size = new System.Drawing.Size(89, 13);
            this.labelSumPayout.TabIndex = 9;
            this.labelSumPayout.Text = "Сумма выплаты";
            // 
            // textBoxSumPayout
            // 
            this.textBoxSumPayout.Location = new System.Drawing.Point(107, 126);
            this.textBoxSumPayout.Name = "textBoxSumPayout";
            this.textBoxSumPayout.Size = new System.Drawing.Size(121, 20);
            this.textBoxSumPayout.TabIndex = 10;
            // 
            // buttonDenied
            // 
            this.buttonDenied.Location = new System.Drawing.Point(161, 182);
            this.buttonDenied.Name = "buttonDenied";
            this.buttonDenied.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDenied.Size = new System.Drawing.Size(90, 23);
            this.buttonDenied.TabIndex = 11;
            this.buttonDenied.Text = "Отказать";
            this.buttonDenied.UseVisualStyleBackColor = true;
            this.buttonDenied.Click += new System.EventHandler(this.buttonDenied_Click);
            // 
            // FormProcessingOfPayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 241);
            this.Controls.Add(this.buttonDenied);
            this.Controls.Add(this.textBoxSumPayout);
            this.Controls.Add(this.labelSumPayout);
            this.Controls.Add(this.textBoxSubcategory);
            this.Controls.Add(this.labelSubcategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxAppeal);
            this.Controls.Add(this.labelAppeal);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.buttonAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormProcessingOfPayout";
            this.Text = "FormRegistrationOfPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelAppeal;
        private System.Windows.Forms.ComboBox comboBoxAppeal;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelSubcategory;
        private System.Windows.Forms.TextBox textBoxSubcategory;
        private System.Windows.Forms.Label labelSumPayout;
        private System.Windows.Forms.TextBox textBoxSumPayout;
        private System.Windows.Forms.Button buttonDenied;
    }
}