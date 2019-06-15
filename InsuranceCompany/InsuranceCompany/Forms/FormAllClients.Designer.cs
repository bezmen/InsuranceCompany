namespace InsuranceCompany
{
    partial class FormAllClients
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonGetIncurence = new System.Windows.Forms.Button();
            this.buttonAddNewCategory = new System.Windows.Forms.Button();
            this.buttonAddNewEmployee = new System.Windows.Forms.Button();
            this.buttonAddNewSubcategory = new System.Windows.Forms.Button();
            this.buttonRegistrationAppeal = new System.Windows.Forms.Button();
            this.buttonRegistrationOfPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(31, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 290);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonGetIncurence
            // 
            this.buttonGetIncurence.Location = new System.Drawing.Point(473, 34);
            this.buttonGetIncurence.Name = "buttonGetIncurence";
            this.buttonGetIncurence.Size = new System.Drawing.Size(144, 23);
            this.buttonGetIncurence.TabIndex = 1;
            this.buttonGetIncurence.Text = "Оформить полис";
            this.buttonGetIncurence.UseVisualStyleBackColor = true;
            this.buttonGetIncurence.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddNewCategory
            // 
            this.buttonAddNewCategory.Location = new System.Drawing.Point(466, 279);
            this.buttonAddNewCategory.Name = "buttonAddNewCategory";
            this.buttonAddNewCategory.Size = new System.Drawing.Size(167, 23);
            this.buttonAddNewCategory.TabIndex = 2;
            this.buttonAddNewCategory.Text = "Добавить категорию полиса";
            this.buttonAddNewCategory.UseVisualStyleBackColor = true;
            this.buttonAddNewCategory.Click += new System.EventHandler(this.buttonAddNewCategory_Click);
            // 
            // buttonAddNewEmployee
            // 
            this.buttonAddNewEmployee.Location = new System.Drawing.Point(466, 336);
            this.buttonAddNewEmployee.Name = "buttonAddNewEmployee";
            this.buttonAddNewEmployee.Size = new System.Drawing.Size(167, 23);
            this.buttonAddNewEmployee.TabIndex = 3;
            this.buttonAddNewEmployee.Text = "Добавить сотрудника";
            this.buttonAddNewEmployee.UseVisualStyleBackColor = true;
            this.buttonAddNewEmployee.Click += new System.EventHandler(this.buttonAddNewEmployee_Click);
            // 
            // buttonAddNewSubcategory
            // 
            this.buttonAddNewSubcategory.Location = new System.Drawing.Point(466, 308);
            this.buttonAddNewSubcategory.Name = "buttonAddNewSubcategory";
            this.buttonAddNewSubcategory.Size = new System.Drawing.Size(167, 23);
            this.buttonAddNewSubcategory.TabIndex = 4;
            this.buttonAddNewSubcategory.Text = "Добавить страховой случай";
            this.buttonAddNewSubcategory.UseVisualStyleBackColor = true;
            this.buttonAddNewSubcategory.Click += new System.EventHandler(this.buttonAddNewSubcategory_Click);
            // 
            // buttonRegistrationAppeal
            // 
            this.buttonRegistrationAppeal.Location = new System.Drawing.Point(473, 63);
            this.buttonRegistrationAppeal.Name = "buttonRegistrationAppeal";
            this.buttonRegistrationAppeal.Size = new System.Drawing.Size(144, 23);
            this.buttonRegistrationAppeal.TabIndex = 5;
            this.buttonRegistrationAppeal.Text = "Оформить обращение";
            this.buttonRegistrationAppeal.UseVisualStyleBackColor = true;
            this.buttonRegistrationAppeal.Click += new System.EventHandler(this.buttonRegistrationAppeal_Click);
            // 
            // buttonRegistrationOfPayment
            // 
            this.buttonRegistrationOfPayment.Location = new System.Drawing.Point(473, 92);
            this.buttonRegistrationOfPayment.Name = "buttonRegistrationOfPayment";
            this.buttonRegistrationOfPayment.Size = new System.Drawing.Size(144, 23);
            this.buttonRegistrationOfPayment.TabIndex = 6;
            this.buttonRegistrationOfPayment.Text = "Оформление выплаты";
            this.buttonRegistrationOfPayment.UseVisualStyleBackColor = true;
            this.buttonRegistrationOfPayment.Click += new System.EventHandler(this.buttonRegistrationOfPayment_Click);
            // 
            // FormAllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 376);
            this.Controls.Add(this.buttonRegistrationOfPayment);
            this.Controls.Add(this.buttonRegistrationAppeal);
            this.Controls.Add(this.buttonAddNewSubcategory);
            this.Controls.Add(this.buttonAddNewEmployee);
            this.Controls.Add(this.buttonAddNewCategory);
            this.Controls.Add(this.buttonGetIncurence);
            this.Controls.Add(this.listView1);
            this.Name = "FormAllClients";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGetIncurence;
        private System.Windows.Forms.Button buttonAddNewCategory;
        private System.Windows.Forms.Button buttonAddNewEmployee;
        private System.Windows.Forms.Button buttonAddNewSubcategory;
        private System.Windows.Forms.Button buttonRegistrationAppeal;
        private System.Windows.Forms.Button buttonRegistrationOfPayment;
        protected internal System.Windows.Forms.ListView listView1;
    }
}

