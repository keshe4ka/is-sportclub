namespace winforms
{
    partial class AddCompetition
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.place_textbox = new System.Windows.Forms.TextBox();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idreferee_comboBox = new System.Windows.Forms.ComboBox();
            this.idsportsman_comboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sport_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(19, 249);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 34);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ОК";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(275, 249);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(149, 25);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(175, 22);
            this.name_textbox.TabIndex = 3;
            // 
            // place_textbox
            // 
            this.place_textbox.Location = new System.Drawing.Point(149, 82);
            this.place_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.place_textbox.Name = "place_textbox";
            this.place_textbox.Size = new System.Drawing.Size(175, 22);
            this.place_textbox.TabIndex = 4;
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(149, 111);
            this.result_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.Size = new System.Drawing.Size(175, 22);
            this.result_textbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вид спорта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Занятое место:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Результат:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "id Спортсмена:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "id Судьи:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idreferee_comboBox);
            this.groupBox1.Controls.Add(this.idsportsman_comboBox);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.name_textbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sport_combobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.place_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.result_textbox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(339, 231);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cоревнование";
            // 
            // idreferee_comboBox
            // 
            this.idreferee_comboBox.FormattingEnabled = true;
            this.idreferee_comboBox.Location = new System.Drawing.Point(149, 194);
            this.idreferee_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idreferee_comboBox.Name = "idreferee_comboBox";
            this.idreferee_comboBox.Size = new System.Drawing.Size(103, 24);
            this.idreferee_comboBox.TabIndex = 19;
            // 
            // idsportsman_comboBox
            // 
            this.idsportsman_comboBox.FormattingEnabled = true;
            this.idsportsman_comboBox.Location = new System.Drawing.Point(149, 138);
            this.idsportsman_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idsportsman_comboBox.Name = "idsportsman_comboBox";
            this.idsportsman_comboBox.Size = new System.Drawing.Size(103, 24);
            this.idsportsman_comboBox.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 167);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // sport_combobox
            // 
            this.sport_combobox.FormattingEnabled = true;
            this.sport_combobox.Location = new System.Drawing.Point(149, 53);
            this.sport_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sport_combobox.Name = "sport_combobox";
            this.sport_combobox.Size = new System.Drawing.Size(175, 24);
            this.sport_combobox.TabIndex = 16;
            // 
            // AddCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(376, 295);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCompetition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить соревнование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox place_textbox;
        private System.Windows.Forms.TextBox result_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sport_combobox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox idreferee_comboBox;
        private System.Windows.Forms.ComboBox idsportsman_comboBox;
    }
}