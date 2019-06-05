using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany.Forms
{
    public partial class FormInformClient : Form
    {
        List<Client> clients;
        List<Employee> employees;
        FormAllClients main;

        public FormInformClient(List<Client> clients, List<Employee> employees, FormAllClients main)
        {
            InitializeComponent();
            this.clients = clients;
            this.employees = employees;
            this.main = main;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIndivid.Checked == true)
            {
                removeEntityComponents();

                #region Individ componets

                this.labelFIO = new System.Windows.Forms.Label();
                this.textBoxFIO = new System.Windows.Forms.TextBox();
                this.labelBirthday = new System.Windows.Forms.Label();
                this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
                this.labelSex = new System.Windows.Forms.Label();
                this.labelStoolDryving = new System.Windows.Forms.Label();
                this.labelAddress = new System.Windows.Forms.Label();
                this.labelTelephone = new System.Windows.Forms.Label();
                this.textBoxStoolDryving = new System.Windows.Forms.TextBox();
                this.textBoxAddress = new System.Windows.Forms.TextBox();
                this.textBoxTelephone = new System.Windows.Forms.TextBox();
                this.checkBoxFemale = new System.Windows.Forms.CheckBox();
                this.checkBoxMale = new System.Windows.Forms.CheckBox();

                this.SuspendLayout();
                // 
                // labelFIO
                // 
                this.labelFIO.AutoSize = true;
                this.labelFIO.Location = new System.Drawing.Point(12, 96);
                this.labelFIO.Name = "labelFIO";
                this.labelFIO.Size = new System.Drawing.Size(34, 13);
                this.labelFIO.TabIndex = 2;
                this.labelFIO.Text = "ФИО";
                // 
                // textBoxFIO
                // 
                this.textBoxFIO.Location = new System.Drawing.Point(155, 93);
                this.textBoxFIO.Name = "textBoxFIO";
                this.textBoxFIO.Size = new System.Drawing.Size(193, 20);
                this.textBoxFIO.TabIndex = 3;
                // 
                // labelBirthday
                // 
                this.labelBirthday.AutoSize = true;
                this.labelBirthday.Location = new System.Drawing.Point(12, 144);
                this.labelBirthday.Name = "labelBirthday";
                this.labelBirthday.Size = new System.Drawing.Size(87, 13);
                this.labelBirthday.TabIndex = 4;
                this.labelBirthday.Text = "День рождения";
                // 
                // dateTimePickerBirthday
                // 
                this.dateTimePickerBirthday.Location = new System.Drawing.Point(155, 138);
                this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
                this.dateTimePickerBirthday.Size = new System.Drawing.Size(193, 20);
                this.dateTimePickerBirthday.TabIndex = 5;
                // 
                // labelSex
                // 
                this.labelSex.AutoSize = true;
                this.labelSex.Location = new System.Drawing.Point(12, 189);
                this.labelSex.Name = "labelSex";
                this.labelSex.Size = new System.Drawing.Size(27, 13);
                this.labelSex.TabIndex = 6;
                this.labelSex.Text = "Пол";
                // 
                // labelStoolDryving
                // 
                this.labelStoolDryving.AutoSize = true;
                this.labelStoolDryving.Location = new System.Drawing.Point(12, 227);
                this.labelStoolDryving.Name = "labelStoolDryving";
                this.labelStoolDryving.Size = new System.Drawing.Size(86, 13);
                this.labelStoolDryving.TabIndex = 7;
                this.labelStoolDryving.Text = "Стаж вождения";
                // 
                // labelAddress
                // 
                this.labelAddress.AutoSize = true;
                this.labelAddress.Location = new System.Drawing.Point(12, 269);
                this.labelAddress.Name = "labelAddress";
                this.labelAddress.Size = new System.Drawing.Size(38, 13);
                this.labelAddress.TabIndex = 8;
                this.labelAddress.Text = "Адрес";
                // 
                // labelTelephone
                // 
                this.labelTelephone.AutoSize = true;
                this.labelTelephone.Location = new System.Drawing.Point(12, 303);
                this.labelTelephone.Name = "labelTelephone";
                this.labelTelephone.Size = new System.Drawing.Size(52, 13);
                this.labelTelephone.TabIndex = 9;
                this.labelTelephone.Text = "Телефон";
                // 
                // textBoxStoolDryving
                // 
                this.textBoxStoolDryving.Location = new System.Drawing.Point(155, 227);
                this.textBoxStoolDryving.Name = "textBoxStoolDryving";
                this.textBoxStoolDryving.Size = new System.Drawing.Size(29, 20);
                this.textBoxStoolDryving.TabIndex = 10;
                // 
                // textBoxAddress
                // 
                this.textBoxAddress.Location = new System.Drawing.Point(155, 269);
                this.textBoxAddress.Name = "textBoxAddress";
                this.textBoxAddress.Size = new System.Drawing.Size(120, 20);
                this.textBoxAddress.TabIndex = 11;
                // 
                // textBoxTelephone
                // 
                this.textBoxTelephone.Location = new System.Drawing.Point(155, 303);
                this.textBoxTelephone.Name = "textBoxTelephone";
                this.textBoxTelephone.Size = new System.Drawing.Size(120, 20);
                this.textBoxTelephone.TabIndex = 12;
                // 
                // checkBoxFemale
                // 
                this.checkBoxFemale.AutoSize = true;
                this.checkBoxFemale.Location = new System.Drawing.Point(255, 189);
                this.checkBoxFemale.Name = "checkBoxFemale";
                this.checkBoxFemale.Size = new System.Drawing.Size(76, 17);
                this.checkBoxFemale.TabIndex = 14;
                this.checkBoxFemale.Text = "Женщина";
                this.checkBoxFemale.UseVisualStyleBackColor = true;
                this.checkBoxFemale.Click += new EventHandler(cbClick);
                // 
                // checkBoxMale
                // 
                this.checkBoxMale.AutoSize = true;
                this.checkBoxMale.Location = new System.Drawing.Point(155, 189);
                this.checkBoxMale.Name = "checkBoxMale";
                this.checkBoxMale.Size = new System.Drawing.Size(71, 17);
                this.checkBoxMale.TabIndex = 13;
                this.checkBoxMale.Text = "Мужчина";
                this.checkBoxMale.UseVisualStyleBackColor = true;
                this.checkBoxMale.Click += new EventHandler(cbClick);

                this.Controls.Add(this.checkBoxFemale);
                this.Controls.Add(this.checkBoxMale);
                this.Controls.Add(this.textBoxTelephone);
                this.Controls.Add(this.textBoxAddress);
                this.Controls.Add(this.textBoxStoolDryving);
                this.Controls.Add(this.labelTelephone);
                this.Controls.Add(this.labelAddress);
                this.Controls.Add(this.labelStoolDryving);
                this.Controls.Add(this.labelSex);
                this.Controls.Add(this.dateTimePickerBirthday);
                this.Controls.Add(this.labelBirthday);
                this.Controls.Add(this.textBoxFIO);
                this.Controls.Add(this.labelFIO);

                this.ResumeLayout(false);
                this.PerformLayout();

                #endregion
            }
            else
            {
                removeIndividComponents();
                #region Entity components

                this.labelNameCompany = new System.Windows.Forms.Label();
                this.textBoxNameCompany = new System.Windows.Forms.TextBox();
                this.labelUTN = new System.Windows.Forms.Label();
                this.textBoxUTN = new System.Windows.Forms.TextBox();
                this.labelFIO_Director = new System.Windows.Forms.Label();
                this.textBoxFIO_Director = new System.Windows.Forms.TextBox();
                this.labelFIO_ChiefAccountant = new System.Windows.Forms.Label();
                this.textBoxFIO_ChiefAccountant = new System.Windows.Forms.TextBox();
                this.labelAddres = new System.Windows.Forms.Label();
                this.textBoxAddres = new System.Windows.Forms.TextBox();
                this.labelTelephon = new System.Windows.Forms.Label();
                this.textBoxTelephon = new System.Windows.Forms.TextBox();
                // 
                // labelNameCompany
                // 
                this.labelNameCompany.AutoSize = true;
                this.labelNameCompany.Location = new System.Drawing.Point(12, 91);
                this.labelNameCompany.Name = "labelNameCompany";
                this.labelNameCompany.Size = new System.Drawing.Size(110, 13);
                this.labelNameCompany.TabIndex = 2;
                this.labelNameCompany.Text = "Название компании";
                // 
                // textBoxNameCompany
                // 
                this.textBoxNameCompany.Location = new System.Drawing.Point(188, 91);
                this.textBoxNameCompany.Name = "textBoxNameCompany";
                this.textBoxNameCompany.Size = new System.Drawing.Size(128, 20);
                this.textBoxNameCompany.TabIndex = 3;
                // 
                // labelUTN
                // 
                this.labelUTN.AutoSize = true;
                this.labelUTN.Location = new System.Drawing.Point(12, 129);
                this.labelUTN.Name = "labelUTN";
                this.labelUTN.Size = new System.Drawing.Size(31, 13);
                this.labelUTN.TabIndex = 4;
                this.labelUTN.Text = "УНН";
                // 
                // textBoxUTN
                // 
                this.textBoxUTN.Location = new System.Drawing.Point(188, 129);
                this.textBoxUTN.Name = "textBoxUTN";
                this.textBoxUTN.Size = new System.Drawing.Size(128, 20);
                this.textBoxUTN.TabIndex = 5;
                // 
                // labelFIO_Director
                // 
                this.labelFIO_Director.AutoSize = true;
                this.labelFIO_Director.Location = new System.Drawing.Point(12, 167);
                this.labelFIO_Director.Name = "labelFIO_Director";
                this.labelFIO_Director.Size = new System.Drawing.Size(90, 13);
                this.labelFIO_Director.TabIndex = 6;
                this.labelFIO_Director.Text = "ФИО директора";
                // 
                // textBoxFIO_Director
                // 
                this.textBoxFIO_Director.Location = new System.Drawing.Point(188, 167);
                this.textBoxFIO_Director.Name = "textBoxFIO_Director";
                this.textBoxFIO_Director.Size = new System.Drawing.Size(128, 20);
                this.textBoxFIO_Director.TabIndex = 7;
                // 
                // labelFIO_ChiefAccountant
                // 
                this.labelFIO_ChiefAccountant.AutoSize = true;
                this.labelFIO_ChiefAccountant.Location = new System.Drawing.Point(12, 207);
                this.labelFIO_ChiefAccountant.Name = "labelFIO_ChiefAccountant";
                this.labelFIO_ChiefAccountant.Size = new System.Drawing.Size(82, 13);
                this.labelFIO_ChiefAccountant.TabIndex = 8;
                this.labelFIO_ChiefAccountant.Text = "ФИО главбуха";
                // 
                // textBoxFIO_ChiefAccountant
                // 
                this.textBoxFIO_ChiefAccountant.Location = new System.Drawing.Point(188, 207);
                this.textBoxFIO_ChiefAccountant.Name = "textBoxFIO_ChiefAccountant";
                this.textBoxFIO_ChiefAccountant.Size = new System.Drawing.Size(128, 20);
                this.textBoxFIO_ChiefAccountant.TabIndex = 9;
                // 
                // labelAddres
                // 
                this.labelAddres.AutoSize = true;
                this.labelAddres.Location = new System.Drawing.Point(12, 249);
                this.labelAddres.Name = "labelAddres";
                this.labelAddres.Size = new System.Drawing.Size(38, 13);
                this.labelAddres.TabIndex = 10;
                this.labelAddres.Text = "Адрес";
                // 
                // textBoxAddres
                // 
                this.textBoxAddres.Location = new System.Drawing.Point(188, 242);
                this.textBoxAddres.Name = "textBoxAddres";
                this.textBoxAddres.Size = new System.Drawing.Size(128, 20);
                this.textBoxAddres.TabIndex = 11;
                // 
                // labelTelephon
                // 
                this.labelTelephon.AutoSize = true;
                this.labelTelephon.Location = new System.Drawing.Point(12, 289);
                this.labelTelephon.Name = "labelTelephon";
                this.labelTelephon.Size = new System.Drawing.Size(52, 13);
                this.labelTelephon.TabIndex = 12;
                this.labelTelephon.Text = "Телефон";
                // 
                // textBoxTelephon
                // 
                this.textBoxTelephon.Location = new System.Drawing.Point(188, 286);
                this.textBoxTelephon.Name = "textBoxTelephon";
                this.textBoxTelephon.Size = new System.Drawing.Size(128, 20);
                this.textBoxTelephon.TabIndex = 13;

                this.Controls.Add(this.textBoxTelephon);
                this.Controls.Add(this.labelTelephon);
                this.Controls.Add(this.textBoxAddres);
                this.Controls.Add(this.labelAddres);
                this.Controls.Add(this.textBoxFIO_ChiefAccountant);
                this.Controls.Add(this.labelFIO_ChiefAccountant);
                this.Controls.Add(this.textBoxFIO_Director);
                this.Controls.Add(this.labelFIO_Director);
                this.Controls.Add(this.textBoxUTN);
                this.Controls.Add(this.labelUTN);
                this.Controls.Add(this.textBoxNameCompany);
                this.Controls.Add(this.labelNameCompany);

                #endregion
            }
        }

        private void removeIndividComponents()
        {
            this.Controls.Remove(labelFIO);
            this.Controls.Remove(textBoxFIO);
            this.Controls.Remove(labelBirthday);
            this.Controls.Remove(dateTimePickerBirthday);
            this.Controls.Remove(labelSex);
            this.Controls.Remove(labelStoolDryving);
            this.Controls.Remove(labelAddress);
            this.Controls.Remove(labelTelephone);
            this.Controls.Remove(textBoxStoolDryving);
            this.Controls.Remove(textBoxAddress);
            this.Controls.Remove(textBoxTelephone);
            this.Controls.Remove(checkBoxFemale);
            this.Controls.Remove(checkBoxMale);
        }

        private void removeEntityComponents()
        {
            this.Controls.Remove(labelNameCompany);
            this.Controls.Remove(textBoxNameCompany);
            this.Controls.Remove(labelUTN);
            this.Controls.Remove(textBoxUTN);
            this.Controls.Remove(labelFIO_Director);
            this.Controls.Remove(textBoxFIO_Director);
            this.Controls.Remove(labelFIO_ChiefAccountant);
            this.Controls.Remove(textBoxFIO_ChiefAccountant);
            this.Controls.Remove(labelAddres);
            this.Controls.Remove(textBoxAddres);
            this.Controls.Remove(labelTelephon);
            this.Controls.Remove(textBoxTelephon);
        }

        private void cbClick(object sender, EventArgs e)
        {
            checkBoxFemale.Checked = false;
            checkBoxMale.Checked = false;
            (sender as CheckBox).Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonIndivid.Checked)
            {
                IndividualClient client = new IndividualClient(
                    textBoxFIO.Text,
                    dateTimePickerBirthday.Value,
                    checkBoxMale.Checked,
                    Convert.ToInt32(textBoxStoolDryving.Text),
                    textBoxAddress.Text,
                    textBoxTelephone.Text
                    );
                clients.Add(client);
            }
            else
            {
                EntityClient client = new EntityClient(
                    textBoxNameCompany.Text,
                    Convert.ToInt32(textBoxUTN.Text),
                    textBoxFIO_Director.Text,
                    textBoxFIO_ChiefAccountant.Text,
                    textBoxAddres.Text,
                    textBoxTelephon.Text
                    );
                clients.Add(client);
            }
            FormPolicy startForm = new FormPolicy(clients, employees, main);
            startForm.Show();
        }
    }
}
