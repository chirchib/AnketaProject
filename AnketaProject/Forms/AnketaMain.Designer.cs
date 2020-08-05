namespace AnketaProject
{
    partial class AnketaMain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SetName = new System.Windows.Forms.TextBox();
            this.SetSurname = new System.Windows.Forms.TextBox();
            this.ageUpDown = new System.Windows.Forms.DomainUpDown();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(98, 59);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 17);
            this.name.TabIndex = 12;
            this.name.Text = "Name:";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(98, 95);
            this.surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(69, 17);
            this.surname.TabIndex = 13;
            this.surname.Text = "Surname:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.Location = new System.Drawing.Point(98, 136);
            this.age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(37, 17);
            this.age.TabIndex = 14;
            this.age.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gender:";
            // 
            // SetName
            // 
            this.SetName.Location = new System.Drawing.Point(175, 59);
            this.SetName.Margin = new System.Windows.Forms.Padding(4);
            this.SetName.Name = "SetName";
            this.SetName.Size = new System.Drawing.Size(275, 20);
            this.SetName.TabIndex = 16;
            // 
            // SetSurname
            // 
            this.SetSurname.Location = new System.Drawing.Point(175, 95);
            this.SetSurname.Margin = new System.Windows.Forms.Padding(4);
            this.SetSurname.Name = "SetSurname";
            this.SetSurname.Size = new System.Drawing.Size(275, 20);
            this.SetSurname.TabIndex = 17;
            // 
            // ageUpDown
            // 
            this.ageUpDown.Location = new System.Drawing.Point(175, 133);
            this.ageUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(85, 20);
            this.ageUpDown.TabIndex = 18;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonMale.Location = new System.Drawing.Point(175, 174);
            this.RadioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(56, 21);
            this.RadioButtonMale.TabIndex = 19;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonFemale.Location = new System.Drawing.Point(250, 174);
            this.RadioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(72, 21);
            this.RadioButtonFemale.TabIndex = 20;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(28, 247);
            this.ButtonSend.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(164, 28);
            this.ButtonSend.TabIndex = 21;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            // 
            // AnketaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(559, 286);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.SetSurname);
            this.Controls.Add(this.SetName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Name = "AnketaMain";
            this.Text = "Anketa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SetName;
        private System.Windows.Forms.TextBox SetSurname;
        private System.Windows.Forms.DomainUpDown ageUpDown;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.Button ButtonSend;
    }
}