namespace winforms
{
    partial class AddSport
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.namesport_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.worldrecord_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addUserButton.Location = new System.Drawing.Point(124, 187);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(124, 36);
            this.addUserButton.TabIndex = 20;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.namesport_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.worldrecord_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(339, 146);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид спорта";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 97);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 22);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 9, 0, 0, 0, 0);
            // 
            // namesport_textbox
            // 
            this.namesport_textbox.Location = new System.Drawing.Point(142, 30);
            this.namesport_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namesport_textbox.Name = "namesport_textbox";
            this.namesport_textbox.Size = new System.Drawing.Size(175, 22);
            this.namesport_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название:";
            // 
            // worldrecord_textbox
            // 
            this.worldrecord_textbox.Location = new System.Drawing.Point(142, 64);
            this.worldrecord_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.worldrecord_textbox.Name = "worldrecord_textbox";
            this.worldrecord_textbox.Size = new System.Drawing.Size(175, 22);
            this.worldrecord_textbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата рекорда:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Мировой рекорд:";
            // 
            // AddSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(364, 238);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить вид спорта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox namesport_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox worldrecord_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}