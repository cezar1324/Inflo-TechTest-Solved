using System.Windows.Forms;

namespace MyApp.WinForm
{
    partial class EditUser
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
            ComboBoxItem comboBoxItem3 = new ComboBoxItem();
            ComboBoxItem comboBoxItem4 = new ComboBoxItem();
            dateTimePicker = new System.Windows.Forms.DateTimePicker();
            comboBoxIsActive = new System.Windows.Forms.ComboBox();
            textBoxSurname = new System.Windows.Forms.TextBox();
            textBoxForname = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            buttonEditUser = new System.Windows.Forms.Button();
            buttonBack = new System.Windows.Forms.Button();

            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new System.Drawing.Point(179, 190);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new System.Drawing.Size(250, 27);
            dateTimePicker.TabIndex = 21;
            // 
            // comboBoxIsActive
            // 
            comboBoxIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIsActive.FormattingEnabled = true;
            comboBoxItem3.text = "true";
            comboBoxItem3.value = true;
            comboBoxItem4.text = "false";
            comboBoxItem4.value = false;
            comboBoxIsActive.Items.AddRange(new object[] { comboBoxItem3, comboBoxItem4 });
            comboBoxIsActive.Location = new System.Drawing.Point(146, 142);
            comboBoxIsActive.Name = "comboBoxIsActive";
            comboBoxIsActive.Size = new System.Drawing.Size(151, 28);
            comboBoxIsActive.TabIndex = 20;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new System.Drawing.Point(146, 95);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new System.Drawing.Size(341, 27);
            textBoxSurname.TabIndex = 19;
            // 
            // textBoxForname
            // 
            textBoxForname.Location = new System.Drawing.Point(146, 50);
            textBoxForname.Name = "textBoxForname";
            textBoxForname.Size = new System.Drawing.Size(341, 27);
            textBoxForname.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(42, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(131, 28);
            label4.TabIndex = 17;
            label4.Text = "Date of Birth: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(42, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 28);
            label3.TabIndex = 16;
            label3.Text = "IsActive: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(42, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 28);
            label2.TabIndex = 15;
            label2.Text = "Surname: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(42, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 28);
            label1.TabIndex = 14;
            label1.Text = "Forname: ";
            // 
            // buttonEditUser
            // 
            buttonEditUser.Location = new System.Drawing.Point(12, 382);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new System.Drawing.Size(161, 56);
            buttonEditUser.TabIndex = 22;
            buttonEditUser.Text = "Edit User";
            buttonEditUser.UseVisualStyleBackColor = true;
            buttonEditUser.Click += buttonEditUser_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new System.Drawing.Point(678, 382);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(110, 56);
            buttonBack.TabIndex = 23;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonEditUser);
            Controls.Add(dateTimePicker);
            Controls.Add(comboBoxIsActive);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxForname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditUser";
            Text = "EditUser";
            Load += EditUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxIsActive;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxForname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonBack;
    }

}