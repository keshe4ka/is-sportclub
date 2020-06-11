namespace winforms
{
    partial class AddExercise
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
            this.addExerciseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discription_textBox = new System.Windows.Forms.TextBox();
            this.nameExercise_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addExerciseButton
            // 
            this.addExerciseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExerciseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addExerciseButton.Location = new System.Drawing.Point(150, 181);
            this.addExerciseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addExerciseButton.Name = "addExerciseButton";
            this.addExerciseButton.Size = new System.Drawing.Size(124, 36);
            this.addExerciseButton.TabIndex = 26;
            this.addExerciseButton.Text = "Добавить";
            this.addExerciseButton.UseVisualStyleBackColor = true;
            this.addExerciseButton.Click += new System.EventHandler(this.addExerciseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.discription_textBox);
            this.groupBox1.Controls.Add(this.nameExercise_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(376, 161);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление упражнений";
            // 
            // discription_textBox
            // 
            this.discription_textBox.Location = new System.Drawing.Point(138, 68);
            this.discription_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discription_textBox.Multiline = true;
            this.discription_textBox.Name = "discription_textBox";
            this.discription_textBox.Size = new System.Drawing.Size(212, 74);
            this.discription_textBox.TabIndex = 28;
            // 
            // nameExercise_textBox
            // 
            this.nameExercise_textBox.Location = new System.Drawing.Point(138, 33);
            this.nameExercise_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameExercise_textBox.Name = "nameExercise_textBox";
            this.nameExercise_textBox.Size = new System.Drawing.Size(121, 22);
            this.nameExercise_textBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название:";
            // 
            // AddExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(414, 231);
            this.Controls.Add(this.addExerciseButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить упражнение";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addExerciseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox discription_textBox;
        private System.Windows.Forms.TextBox nameExercise_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}