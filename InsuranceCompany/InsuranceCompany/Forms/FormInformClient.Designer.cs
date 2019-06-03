namespace InsuranceCompany.Forms
{
    partial class FormInformClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonIndivid = new System.Windows.Forms.RadioButton();
            this.radioButtonEntity = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonIndivid
            // 
            this.radioButtonIndivid.AutoSize = true;
            this.radioButtonIndivid.Location = new System.Drawing.Point(24, 23);
            this.radioButtonIndivid.Name = "radioButtonIndivid";
            this.radioButtonIndivid.Size = new System.Drawing.Size(78, 17);
            this.radioButtonIndivid.TabIndex = 0;
            this.radioButtonIndivid.TabStop = true;
            this.radioButtonIndivid.Text = "Физ. лицо";
            this.radioButtonIndivid.UseVisualStyleBackColor = true;
            this.radioButtonIndivid.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonEntity
            // 
            this.radioButtonEntity.AutoSize = true;
            this.radioButtonEntity.Location = new System.Drawing.Point(246, 23);
            this.radioButtonEntity.Name = "radioButtonEntity";
            this.radioButtonEntity.Size = new System.Drawing.Size(70, 17);
            this.radioButtonEntity.TabIndex = 1;
            this.radioButtonEntity.TabStop = true;
            this.radioButtonEntity.Text = "Юр. лицо";
            this.radioButtonEntity.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonEntity);
            this.Controls.Add(this.radioButtonIndivid);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonIndivid;
        private System.Windows.Forms.RadioButton radioButtonEntity;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelStoolDryving;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox textBoxStoolDryving;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.Label labelNameCompany;
        private System.Windows.Forms.TextBox textBoxNameCompany;
        private System.Windows.Forms.Label labelUTN;
        private System.Windows.Forms.TextBox textBoxUTN;
        private System.Windows.Forms.Label labelFIO_Director;
        private System.Windows.Forms.TextBox textBoxFIO_Director;
        private System.Windows.Forms.Label labelFIO_ChiefAccountant;
        private System.Windows.Forms.TextBox textBoxFIO_ChiefAccountant;
        private System.Windows.Forms.Label labelAddres;
        private System.Windows.Forms.TextBox textBoxAddres;
        private System.Windows.Forms.Label labelTelephon;
        private System.Windows.Forms.TextBox textBoxTelephon;
        private System.Windows.Forms.Button button1;
    }
}