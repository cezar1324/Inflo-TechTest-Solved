namespace MyApp.WinForm
{
    partial class AddUser
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
            ComboBoxItem comboBoxItem1 = new ComboBoxItem();
            ComboBoxItem comboBoxItem2 = new ComboBoxItem();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBoxForname = new System.Windows.Forms.TextBox();
            textBoxSurname = new System.Windows.Forms.TextBox();
            comboBoxIsActive = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(37, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "Forname: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(37, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 28);
            label2.TabIndex = 1;
            label2.Text = "Surname: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(37, 137);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 28);
            label3.TabIndex = 2;
            label3.Text = "IsActive: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(37, 187);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(131, 28);
            label4.TabIndex = 3;
            label4.Text = "Date of Birth: ";
            // 
            // textBoxForname
            // 
            textBoxForname.Location = new System.Drawing.Point(141, 49);
            textBoxForname.Name = "textBoxForname";
            textBoxForname.Size = new System.Drawing.Size(341, 27);
            textBoxForname.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new System.Drawing.Point(141, 94);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new System.Drawing.Size(341, 27);
            textBoxSurname.TabIndex = 5;
            // 
            // comboBoxIsActive
            // 
            comboBoxIsActive.FormattingEnabled = true;
            comboBoxItem1.text = "true";
            comboBoxItem1.value = true;
            comboBoxItem2.text = "false";
            comboBoxItem2.value = false;
            comboBoxIsActive.Items.AddRange(new object[] { comboBoxItem1, comboBoxItem2 });
            comboBoxIsActive.Location = new System.Drawing.Point(141, 141);
            comboBoxIsActive.Name = "comboBoxIsActive";
            comboBoxIsActive.Size = new System.Drawing.Size(151, 28);
            comboBoxIsActive.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(678, 382);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(110, 56);
            button1.TabIndex = 10;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 382);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(123, 56);
            button2.TabIndex = 11;
            button2.Text = "Add New User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new System.Drawing.Point(174, 189);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new System.Drawing.Size(250, 27);
            dateTimePicker.TabIndex = 13;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dateTimePicker);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxIsActive);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxForname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxForname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.ComboBox comboBoxIsActive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}