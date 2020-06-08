namespace winforms
{
    partial class Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.searchsportsmen_textBox = new System.Windows.Forms.TextBox();
            this.searchSportsman_Button = new System.Windows.Forms.Button();
            this.AddSportsmanButton = new System.Windows.Forms.Button();
            this.MuSportsmanButton = new System.Windows.Forms.Button();
            this.AllSportsmanButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delete_programm_training = new System.Windows.Forms.Button();
            this.addProgramm_training = new System.Windows.Forms.Button();
            this.programm_training_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.delete_nutrition_programm = new System.Windows.Forms.Button();
            this.add_nutrition_programm = new System.Windows.Forms.Button();
            this.nutrition_programm_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cometition_trainer_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sports_dataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programm_training_dataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutrition_programm_dataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cometition_trainer_dataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sports_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(8, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.searchsportsmen_textBox);
            this.tabPage1.Controls.Add(this.searchSportsman_Button);
            this.tabPage1.Controls.Add(this.AddSportsmanButton);
            this.tabPage1.Controls.Add(this.MuSportsmanButton);
            this.tabPage1.Controls.Add(this.AllSportsmanButton);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(642, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Спортсмены";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поиск спортсмена";
            // 
            // searchsportsmen_textBox
            // 
            this.searchsportsmen_textBox.Location = new System.Drawing.Point(112, 15);
            this.searchsportsmen_textBox.Name = "searchsportsmen_textBox";
            this.searchsportsmen_textBox.Size = new System.Drawing.Size(176, 20);
            this.searchsportsmen_textBox.TabIndex = 11;
            // 
            // searchSportsman_Button
            // 
            this.searchSportsman_Button.Location = new System.Drawing.Point(293, 4);
            this.searchSportsman_Button.Margin = new System.Windows.Forms.Padding(2);
            this.searchSportsman_Button.Name = "searchSportsman_Button";
            this.searchSportsman_Button.Size = new System.Drawing.Size(92, 40);
            this.searchSportsman_Button.TabIndex = 10;
            this.searchSportsman_Button.Text = "Поиск";
            this.searchSportsman_Button.UseVisualStyleBackColor = true;
            this.searchSportsman_Button.Click += new System.EventHandler(this.searchSportsman_Button_Click);
            // 
            // AddSportsmanButton
            // 
            this.AddSportsmanButton.Location = new System.Drawing.Point(332, 316);
            this.AddSportsmanButton.Name = "AddSportsmanButton";
            this.AddSportsmanButton.Size = new System.Drawing.Size(148, 52);
            this.AddSportsmanButton.TabIndex = 3;
            this.AddSportsmanButton.Text = "Добавить спортсмена к себе";
            this.AddSportsmanButton.UseVisualStyleBackColor = true;
            this.AddSportsmanButton.Click += new System.EventHandler(this.AddSportsmanButton_Click);
            // 
            // MuSportsmanButton
            // 
            this.MuSportsmanButton.Location = new System.Drawing.Point(166, 316);
            this.MuSportsmanButton.Name = "MuSportsmanButton";
            this.MuSportsmanButton.Size = new System.Drawing.Size(160, 52);
            this.MuSportsmanButton.TabIndex = 2;
            this.MuSportsmanButton.Text = "Показать только моих спортсменов";
            this.MuSportsmanButton.UseVisualStyleBackColor = true;
            this.MuSportsmanButton.Click += new System.EventHandler(this.MuSportsmanButton_Click);
            // 
            // AllSportsmanButton
            // 
            this.AllSportsmanButton.Location = new System.Drawing.Point(6, 316);
            this.AllSportsmanButton.Name = "AllSportsmanButton";
            this.AllSportsmanButton.Size = new System.Drawing.Size(154, 52);
            this.AllSportsmanButton.TabIndex = 1;
            this.AllSportsmanButton.Text = "Показать всех спортсменов";
            this.AllSportsmanButton.UseVisualStyleBackColor = true;
            this.AllSportsmanButton.Click += new System.EventHandler(this.AllSportsmanButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(632, 261);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.delete_programm_training);
            this.tabPage2.Controls.Add(this.addProgramm_training);
            this.tabPage2.Controls.Add(this.programm_training_dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(642, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Программы тренировок";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete_programm_training
            // 
            this.delete_programm_training.Location = new System.Drawing.Point(491, 331);
            this.delete_programm_training.Name = "delete_programm_training";
            this.delete_programm_training.Size = new System.Drawing.Size(146, 39);
            this.delete_programm_training.TabIndex = 4;
            this.delete_programm_training.Text = "Удалить";
            this.delete_programm_training.UseVisualStyleBackColor = true;
            // 
            // addProgramm_training
            // 
            this.addProgramm_training.Location = new System.Drawing.Point(6, 331);
            this.addProgramm_training.Name = "addProgramm_training";
            this.addProgramm_training.Size = new System.Drawing.Size(146, 39);
            this.addProgramm_training.TabIndex = 1;
            this.addProgramm_training.Text = "Добавить";
            this.addProgramm_training.UseVisualStyleBackColor = true;
            // 
            // programm_training_dataGridView
            // 
            this.programm_training_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programm_training_dataGridView.Location = new System.Drawing.Point(6, 8);
            this.programm_training_dataGridView.Name = "programm_training_dataGridView";
            this.programm_training_dataGridView.Size = new System.Drawing.Size(631, 317);
            this.programm_training_dataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.delete_nutrition_programm);
            this.tabPage3.Controls.Add(this.add_nutrition_programm);
            this.tabPage3.Controls.Add(this.nutrition_programm_dataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(642, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Программы питания";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // delete_nutrition_programm
            // 
            this.delete_nutrition_programm.Location = new System.Drawing.Point(491, 329);
            this.delete_nutrition_programm.Name = "delete_nutrition_programm";
            this.delete_nutrition_programm.Size = new System.Drawing.Size(146, 39);
            this.delete_nutrition_programm.TabIndex = 8;
            this.delete_nutrition_programm.Text = "Удалить";
            this.delete_nutrition_programm.UseVisualStyleBackColor = true;
            // 
            // add_nutrition_programm
            // 
            this.add_nutrition_programm.Location = new System.Drawing.Point(5, 329);
            this.add_nutrition_programm.Name = "add_nutrition_programm";
            this.add_nutrition_programm.Size = new System.Drawing.Size(146, 39);
            this.add_nutrition_programm.TabIndex = 7;
            this.add_nutrition_programm.Text = "Добавить";
            this.add_nutrition_programm.UseVisualStyleBackColor = true;
            // 
            // nutrition_programm_dataGridView
            // 
            this.nutrition_programm_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nutrition_programm_dataGridView.Location = new System.Drawing.Point(5, 6);
            this.nutrition_programm_dataGridView.Name = "nutrition_programm_dataGridView";
            this.nutrition_programm_dataGridView.Size = new System.Drawing.Size(632, 317);
            this.nutrition_programm_dataGridView.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.search_textbox);
            this.tabPage4.Controls.Add(this.searchButton);
            this.tabPage4.Controls.Add(this.cometition_trainer_dataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(642, 375);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Соревнования";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название соревнования:";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(139, 19);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(176, 20);
            this.search_textbox.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(320, 6);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 40);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cometition_trainer_dataGridView
            // 
            this.cometition_trainer_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cometition_trainer_dataGridView.Location = new System.Drawing.Point(5, 50);
            this.cometition_trainer_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.cometition_trainer_dataGridView.Name = "cometition_trainer_dataGridView";
            this.cometition_trainer_dataGridView.RowTemplate.Height = 24;
            this.cometition_trainer_dataGridView.Size = new System.Drawing.Size(634, 321);
            this.cometition_trainer_dataGridView.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Controls.Add(this.sports_dataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(642, 375);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Виды спорта";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // sports_dataGridView
            // 
            this.sports_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.sports_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sports_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sports_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.sports_dataGridView.Name = "sports_dataGridView";
            this.sports_dataGridView.Size = new System.Drawing.Size(341, 368);
            this.sports_dataGridView.TabIndex = 4;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(486, 316);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(151, 52);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Удалить спортсмена";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 420);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Trainer";
            this.Text = "Trainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trainer_FormClosing_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programm_training_dataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nutrition_programm_dataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cometition_trainer_dataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sports_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView cometition_trainer_dataGridView;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddSportsmanButton;
        private System.Windows.Forms.Button MuSportsmanButton;
        private System.Windows.Forms.Button AllSportsmanButton;
        private System.Windows.Forms.Button delete_programm_training;
        private System.Windows.Forms.Button addProgramm_training;
        private System.Windows.Forms.DataGridView programm_training_dataGridView;
        private System.Windows.Forms.Button delete_nutrition_programm;
        private System.Windows.Forms.Button add_nutrition_programm;
        private System.Windows.Forms.DataGridView nutrition_programm_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView sports_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchsportsmen_textBox;
        private System.Windows.Forms.Button searchSportsman_Button;
        private System.Windows.Forms.Button DeleteButton;
    }
}