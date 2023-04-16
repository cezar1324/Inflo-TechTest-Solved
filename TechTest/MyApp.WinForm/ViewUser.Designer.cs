using System.Windows.Forms;

namespace MyApp.WinForm
{
    partial class ViewUser
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblForename = new System.Windows.Forms.Label();
            lblSurname = new System.Windows.Forms.Label();
            lblIsActive = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            lblDateOfBirth = new System.Windows.Forms.Label();
            logs = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(27, 30);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 29);
            label1.TabIndex = 0;
            label1.Text = "View User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 94);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Forename:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 141);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Surname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 187);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Is Active:";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new System.Drawing.Point(118, 94);
            lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblForename.Name = "lblForename";
            lblForename.Size = new System.Drawing.Size(96, 20);
            lblForename.TabIndex = 4;
            lblForename.Text = "[FORENAME]";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new System.Drawing.Point(118, 141);
            lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(88, 20);
            lblSurname.TabIndex = 5;
            lblSurname.Text = "[SURNAME]";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new System.Drawing.Point(118, 187);
            lblIsActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new System.Drawing.Size(79, 20);
            lblIsActive.TabIndex = 6;
            lblIsActive.Text = "[ISACTIVE]";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(762, 416);
            btnBack.Margin = new System.Windows.Forms.Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(106, 54);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(29, 227);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 20);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth: ";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new System.Drawing.Point(136, 227);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new System.Drawing.Size(113, 20);
            lblDateOfBirth.TabIndex = 9;
            lblDateOfBirth.Text = "[DATEOFBIRTH]";
            // 
            // logs
            // 
            logs.HorizontalScrollbar = true;
            logs.FormattingEnabled = true;
            logs.ItemHeight = 20;
            logs.Location = new System.Drawing.Point(29, 277);
            logs.Name = "logs";
            logs.Size = new System.Drawing.Size(820, 104);
            logs.TabIndex = 10;
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(879, 481);
            Controls.Add(logs);
            Controls.Add(lblDateOfBirth);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(lblIsActive);
            Controls.Add(lblSurname);
            Controls.Add(lblForename);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "ViewUser";
            Text = "ViewUser";
            Load += ViewUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.ListBox logs;
    }
}