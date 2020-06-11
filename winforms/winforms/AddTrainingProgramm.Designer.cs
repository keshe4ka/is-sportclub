namespace winforms
{
    partial class AddTrainingProgramm
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
            this.addSportsmanButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Exercise_id_comboBox = new System.Windows.Forms.ComboBox();
            this.lead_time_textBox = new System.Windows.Forms.TextBox();
            this.number_of_times_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSportsmanButton
            // 
            this.addSportsmanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSportsmanButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addSportsmanButton.Location = new System.Drawing.Point(124, 173);
            this.addSportsmanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSportsmanButton.Name = "addSportsmanButton";
            this.addSportsmanButton.Size = new System.Drawing.Size(124, 36);
            this.addSportsmanButton.TabIndex = 24;
            this.addSportsmanButton.Text = "Добавить";
            this.addSportsmanButton.UseVisualStyleBackColor = true;
            this.addSportsmanButton.Click += new System.EventHandler(this.addSportsmanButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Exercise_id_comboBox);
            this.groupBox1.Controls.Add(this.lead_time_textBox);
            this.groupBox1.Controls.Add(this.number_of_times_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(337, 149);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление программы тренировок";
            // 
            // Exercise_id_comboBox
            // 
            this.Exercise_id_comboBox.FormattingEnabled = true;
            this.Exercise_id_comboBox.Location = new System.Drawing.Point(173, 96);
            this.Exercise_id_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exercise_id_comboBox.Name = "Exercise_id_comboBox";
            this.Exercise_id_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Exercise_id_comboBox.TabIndex = 29;
            // 
            // lead_time_textBox
            // 
            this.lead_time_textBox.Location = new System.Drawing.Point(173, 64);
            this.lead_time_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lead_time_textBox.Name = "lead_time_textBox";
            this.lead_time_textBox.Size = new System.Drawing.Size(121, 22);
            this.lead_time_textBox.TabIndex = 28;
            // 
            // number_of_times_textBox
            // 
            this.number_of_times_textBox.Location = new System.Drawing.Point(173, 32);
            this.number_of_times_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number_of_times_textBox.Name = "number_of_times_textBox";
            this.number_of_times_textBox.Size = new System.Drawing.Size(121, 22);
            this.number_of_times_textBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Время выполнения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количетсво:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "id Упражнения:";
            // 
            // AddTrainingProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(369, 222);
            this.Controls.Add(this.addSportsmanButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTrainingProgramm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить тренировку";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addSportsmanButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lead_time_textBox;
        private System.Windows.Forms.TextBox number_of_times_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Exercise_id_comboBox;
        private System.Windows.Forms.Label label3;
    }
}