namespace winforms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.secondname_textbox = new System.Windows.Forms.TextBox();
            this.role_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.patronymic_textbox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.secondname_textbox);
            this.groupBox1.Controls.Add(this.role_combobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.password_textbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.name_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.login_textbox);
            this.groupBox1.Controls.Add(this.patronymic_textbox);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(254, 192);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользователь";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Пароль";
            // 
            // secondname_textbox
            // 
            this.secondname_textbox.Location = new System.Drawing.Point(110, 17);
            this.secondname_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.secondname_textbox.Name = "secondname_textbox";
            this.secondname_textbox.Size = new System.Drawing.Size(132, 20);
            this.secondname_textbox.TabIndex = 3;
            // 
            // role_combobox
            // 
            this.role_combobox.FormattingEnabled = true;
            this.role_combobox.Location = new System.Drawing.Point(110, 167);
            this.role_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.role_combobox.Name = "role_combobox";
            this.role_combobox.Size = new System.Drawing.Size(132, 21);
            this.role_combobox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фамилия";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(110, 139);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(132, 20);
            this.password_textbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Роль";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(110, 45);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(132, 20);
            this.name_textbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя";
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(110, 108);
            this.login_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(132, 20);
            this.login_textbox.TabIndex = 6;
            // 
            // patronymic_textbox
            // 
            this.patronymic_textbox.Location = new System.Drawing.Point(110, 77);
            this.patronymic_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.patronymic_textbox.Name = "patronymic_textbox";
            this.patronymic_textbox.Size = new System.Drawing.Size(132, 20);
            this.patronymic_textbox.TabIndex = 5;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(85, 208);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(93, 29);
            this.addUserButton.TabIndex = 18;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 249);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondname_textbox;
        private System.Windows.Forms.ComboBox role_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.TextBox patronymic_textbox;
        private System.Windows.Forms.Button addUserButton;
    }
}