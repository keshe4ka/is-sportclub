namespace winforms
{
    partial class AddNutritionProgramm
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
            this.addNutritionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_sportsman_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wish_weight_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNutritionButton
            // 
            this.addNutritionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNutritionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNutritionButton.Location = new System.Drawing.Point(143, 181);
            this.addNutritionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNutritionButton.Name = "addNutritionButton";
            this.addNutritionButton.Size = new System.Drawing.Size(124, 36);
            this.addNutritionButton.TabIndex = 28;
            this.addNutritionButton.Text = "Добавить";
            this.addNutritionButton.UseVisualStyleBackColor = true;
            this.addNutritionButton.Click += new System.EventHandler(this.addNutritionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_sportsman_comboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.wish_weight_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(385, 149);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление программы питания";
            // 
            // id_sportsman_comboBox
            // 
            this.id_sportsman_comboBox.FormattingEnabled = true;
            this.id_sportsman_comboBox.Location = new System.Drawing.Point(164, 70);
            this.id_sportsman_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_sportsman_comboBox.Name = "id_sportsman_comboBox";
            this.id_sportsman_comboBox.Size = new System.Drawing.Size(121, 24);
            this.id_sportsman_comboBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "определится автоматически";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ваш id:";
            // 
            // wish_weight_textBox
            // 
            this.wish_weight_textBox.Location = new System.Drawing.Point(164, 38);
            this.wish_weight_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wish_weight_textBox.Name = "wish_weight_textBox";
            this.wish_weight_textBox.Size = new System.Drawing.Size(121, 22);
            this.wish_weight_textBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Спорсмен:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Желаемый вес:";
            // 
            // AddNutritionProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(417, 230);
            this.Controls.Add(this.addNutritionButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNutritionProgramm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить программу питания";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNutritionButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox wish_weight_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox id_sportsman_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}