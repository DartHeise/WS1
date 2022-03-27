namespace lab4
{
    partial class ProfessorForm
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
            this.Position = new System.Windows.Forms.Label();
            this.disciplinesListBox = new System.Windows.Forms.ListBox();
            this.department = new System.Windows.Forms.Label();
            this.institute = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.skype = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Position.Location = new System.Drawing.Point(13, 56);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(84, 16);
            this.Position.TabIndex = 1;
            this.Position.Text = "Должность: ";
            // 
            // disciplinesListBox
            // 
            this.disciplinesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplinesListBox.FormattingEnabled = true;
            this.disciplinesListBox.ItemHeight = 15;
            this.disciplinesListBox.Location = new System.Drawing.Point(12, 190);
            this.disciplinesListBox.Name = "disciplinesListBox";
            this.disciplinesListBox.Size = new System.Drawing.Size(482, 109);
            this.disciplinesListBox.TabIndex = 2;
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.department.Location = new System.Drawing.Point(13, 90);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(72, 16);
            this.department.TabIndex = 3;
            this.department.Text = "Кафедра: ";
            // 
            // institute
            // 
            this.institute.AutoSize = true;
            this.institute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.institute.Location = new System.Drawing.Point(13, 126);
            this.institute.Name = "institute";
            this.institute.Size = new System.Drawing.Size(75, 16);
            this.institute.TabIndex = 4;
            this.institute.Text = "Институт: ";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(252, 54);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(73, 16);
            this.phone.TabIndex = 6;
            this.phone.Text = "Телефон: ";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail.Location = new System.Drawing.Point(252, 90);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(54, 16);
            this.mail.TabIndex = 7;
            this.mail.Text = "Почта: ";
            // 
            // skype
            // 
            this.skype.AutoSize = true;
            this.skype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skype.Location = new System.Drawing.Point(252, 120);
            this.skype.Name = "skype";
            this.skype.Size = new System.Drawing.Size(52, 16);
            this.skype.TabIndex = 8;
            this.skype.Text = "Skype: ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(13, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 18);
            this.name.TabIndex = 9;
            this.name.Text = "Имя преподавателя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Выберите дисциплину:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenButtonClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Сменить пользователя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangeUserButtonClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Выйти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExitButtonClicked);
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 375);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.name);
            this.Controls.Add(this.skype);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.institute);
            this.Controls.Add(this.department);
            this.Controls.Add(this.disciplinesListBox);
            this.Controls.Add(this.Position);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.ListBox disciplinesListBox;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label institute;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label skype;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}