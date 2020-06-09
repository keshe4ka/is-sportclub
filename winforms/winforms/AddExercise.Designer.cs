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
            this.addExerciseButton.Location = new System.Drawing.Point(135, 147);
            this.addExerciseButton.Name = "addExerciseButton";
            this.addExerciseButton.Size = new System.Drawing.Size(93, 29);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(346, 121);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление упражнений";
            // 
            // discription_textBox
            // 
            this.discription_textBox.Location = new System.Drawing.Point(181, 55);
            this.discription_textBox.Multiline = true;
            this.discription_textBox.Name = "discription_textBox";
            this.discription_textBox.Size = new System.Drawing.Size(160, 61);
            this.discription_textBox.TabIndex = 28;
            // 
            // nameExercise_textBox
            // 
            this.nameExercise_textBox.Location = new System.Drawing.Point(182, 29);
            this.nameExercise_textBox.Name = "nameExercise_textBox";
            this.nameExercise_textBox.Size = new System.Drawing.Size(92, 20);
            this.nameExercise_textBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название:";
            // 
            // AddExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(367, 197);
            this.Controls.Add(this.addExerciseButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddExercise";
            this.Text = "AddExercise";
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