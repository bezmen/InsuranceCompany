namespace InsuranceCompany.Forms
{
    partial class FormClient
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
            this.buttonShowPayouts = new System.Windows.Forms.Button();
            this.buttonShowPolicies = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonGetInsurence = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowPayouts
            // 
            this.buttonShowPayouts.Location = new System.Drawing.Point(203, 299);
            this.buttonShowPayouts.Name = "buttonShowPayouts";
            this.buttonShowPayouts.Size = new System.Drawing.Size(103, 23);
            this.buttonShowPayouts.TabIndex = 0;
            this.buttonShowPayouts.Text = "Спиок выплат";
            this.buttonShowPayouts.UseVisualStyleBackColor = true;
            this.buttonShowPayouts.Click += new System.EventHandler(this.buttonShowPayouts_Click);
            // 
            // buttonShowPolicies
            // 
            this.buttonShowPolicies.Location = new System.Drawing.Point(33, 299);
            this.buttonShowPolicies.Name = "buttonShowPolicies";
            this.buttonShowPolicies.Size = new System.Drawing.Size(124, 23);
            this.buttonShowPolicies.TabIndex = 1;
            this.buttonShowPolicies.Text = "Список полисов";
            this.buttonShowPolicies.UseVisualStyleBackColor = true;
            this.buttonShowPolicies.Click += new System.EventHandler(this.buttonShowPolicies_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(21, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(459, 223);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonGetInsurence
            // 
            this.buttonGetInsurence.Location = new System.Drawing.Point(362, 299);
            this.buttonGetInsurence.Name = "buttonGetInsurence";
            this.buttonGetInsurence.Size = new System.Drawing.Size(102, 23);
            this.buttonGetInsurence.TabIndex = 3;
            this.buttonGetInsurence.Text = "Оформить полис";
            this.buttonGetInsurence.UseVisualStyleBackColor = true;
            this.buttonGetInsurence.Click += new System.EventHandler(this.buttonGetInsurence_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(203, 261);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(103, 23);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "Экспорт";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 340);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonGetInsurence);
            this.Controls.Add(this.buttonShowPolicies);
            this.Controls.Add(this.buttonShowPayouts);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowPayouts;
        private System.Windows.Forms.Button buttonShowPolicies;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonGetInsurence;
        private System.Windows.Forms.Button buttonExport;
    }
}