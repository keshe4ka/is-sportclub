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
            this.wish_weight_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_sportsman_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNutritionButton
            // 
            this.addNutritionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNutritionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNutritionButton.Location = new System.Drawing.Point(134, 146);
            this.addNutritionButton.Name = "addNutritionButton";
            this.addNutritionButton.Size = new System.Drawing.Size(93, 29);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(346, 121);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление программы питания";
            // 
            // wish_weight_textBox
            // 
            this.wish_weight_textBox.Location = new System.Drawing.Point(182, 29);
            this.wish_weight_textBox.Name = "wish_weight_textBox";
            this.wish_weight_textBox.Size = new System.Drawing.Size(92, 20);
            this.wish_weight_textBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Спорсмен:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Желаемый вес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "определится автоматически";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ваш id:";
            // 
            // id_sportsman_comboBox
            // 
            this.id_sportsman_comboBox.FormattingEnabled = true;
            this.id_sportsman_comboBox.Location = new System.Drawing.Point(181, 55);
            this.id_sportsman_comboBox.Name = "id_sportsman_comboBox";
            this.id_sportsman_comboBox.Size = new System.Drawing.Size(93, 21);
            this.id_sportsman_comboBox.TabIndex = 31;
            // 
            // AddNutritionProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(375, 187);
            this.Controls.Add(this.addNutritionButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNutritionProgramm";
            this.Text = "AddNutritionProgramm";
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