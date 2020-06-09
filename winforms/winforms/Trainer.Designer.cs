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
            this.DeleteButton = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.programm_training_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete_Exercise_Betton = new System.Windows.Forms.Button();
            this.Exercise_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutrition_programm_dataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cometition_trainer_dataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sports_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programm_training_dataGridView)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exercise_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
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
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.searchsportsmen_textBox);
            this.tabPage1.Controls.Add(this.searchSportsman_Button);
            this.tabPage1.Controls.Add(this.AddSportsmanButton);
            this.tabPage1.Controls.Add(this.MuSportsmanButton);
            this.tabPage1.Controls.Add(this.AllSportsmanButton);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(642, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Спортсмены";
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(486, 316);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(151, 52);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Удалить спортсмена";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.searchSportsman_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchSportsman_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.AddSportsmanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSportsmanButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.MuSportsmanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuSportsmanButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.AllSportsmanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllSportsmanButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(632, 261);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(642, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Программы тренировок";
            // 
            // delete_programm_training
            // 
            this.delete_programm_training.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_programm_training.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_programm_training.Location = new System.Drawing.Point(480, 312);
            this.delete_programm_training.Name = "delete_programm_training";
            this.delete_programm_training.Size = new System.Drawing.Size(146, 39);
            this.delete_programm_training.TabIndex = 4;
            this.delete_programm_training.Text = "Удалить";
            this.delete_programm_training.UseVisualStyleBackColor = true;
            this.delete_programm_training.Click += new System.EventHandler(this.delete_programm_training_Click);
            // 
            // addProgramm_training
            // 
            this.addProgramm_training.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProgramm_training.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProgramm_training.Location = new System.Drawing.Point(6, 312);
            this.addProgramm_training.Name = "addProgramm_training";
            this.addProgramm_training.Size = new System.Drawing.Size(146, 39);
            this.addProgramm_training.TabIndex = 1;
            this.addProgramm_training.Text = "Добавить";
            this.addProgramm_training.UseVisualStyleBackColor = true;
            this.addProgramm_training.Click += new System.EventHandler(this.addProgramm_training_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.delete_nutrition_programm);
            this.tabPage3.Controls.Add(this.add_nutrition_programm);
            this.tabPage3.Controls.Add(this.nutrition_programm_dataGridView);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(642, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Программы питания";
            // 
            // delete_nutrition_programm
            // 
            this.delete_nutrition_programm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_nutrition_programm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_nutrition_programm.Location = new System.Drawing.Point(491, 329);
            this.delete_nutrition_programm.Name = "delete_nutrition_programm";
            this.delete_nutrition_programm.Size = new System.Drawing.Size(146, 39);
            this.delete_nutrition_programm.TabIndex = 8;
            this.delete_nutrition_programm.Text = "Удалить";
            this.delete_nutrition_programm.UseVisualStyleBackColor = true;
            this.delete_nutrition_programm.Click += new System.EventHandler(this.delete_nutrition_programm_Click);
            // 
            // add_nutrition_programm
            // 
            this.add_nutrition_programm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_nutrition_programm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_nutrition_programm.Location = new System.Drawing.Point(5, 329);
            this.add_nutrition_programm.Name = "add_nutrition_programm";
            this.add_nutrition_programm.Size = new System.Drawing.Size(146, 39);
            this.add_nutrition_programm.TabIndex = 7;
            this.add_nutrition_programm.Text = "Добавить";
            this.add_nutrition_programm.UseVisualStyleBackColor = true;
            this.add_nutrition_programm.Click += new System.EventHandler(this.add_nutrition_programm_Click);
            // 
            // nutrition_programm_dataGridView
            // 
            this.nutrition_programm_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nutrition_programm_dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.nutrition_programm_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nutrition_programm_dataGridView.Location = new System.Drawing.Point(5, 6);
            this.nutrition_programm_dataGridView.Name = "nutrition_programm_dataGridView";
            this.nutrition_programm_dataGridView.Size = new System.Drawing.Size(632, 317);
            this.nutrition_programm_dataGridView.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.search_textbox);
            this.tabPage4.Controls.Add(this.searchButton);
            this.tabPage4.Controls.Add(this.cometition_trainer_dataGridView);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(642, 375);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Соревнования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.cometition_trainer_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cometition_trainer_dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
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
            this.tabPage5.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Controls.Add(this.sports_dataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(642, 375);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Виды спорта";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // sports_dataGridView
            // 
            this.sports_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sports_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sports_dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.sports_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sports_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.sports_dataGridView.Name = "sports_dataGridView";
            this.sports_dataGridView.Size = new System.Drawing.Size(392, 368);
            this.sports_dataGridView.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addProgramm_training);
            this.groupBox1.Controls.Add(this.delete_programm_training);
            this.groupBox1.Controls.Add(this.programm_training_dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 362);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Программы тренировок";
            // 
            // programm_training_dataGridView
            // 
            this.programm_training_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.programm_training_dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.programm_training_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programm_training_dataGridView.Location = new System.Drawing.Point(6, 19);
            this.programm_training_dataGridView.Name = "programm_training_dataGridView";
            this.programm_training_dataGridView.Size = new System.Drawing.Size(620, 287);
            this.programm_training_dataGridView.TabIndex = 5;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage6.Controls.Add(this.groupBox3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(642, 375);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Упражнения";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Delete_Exercise_Betton);
            this.groupBox3.Controls.Add(this.Exercise_dataGridView);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 369);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Упражнения";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(6, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_Exercise_Betton
            // 
            this.Delete_Exercise_Betton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Exercise_Betton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_Exercise_Betton.Location = new System.Drawing.Point(484, 312);
            this.Delete_Exercise_Betton.Name = "Delete_Exercise_Betton";
            this.Delete_Exercise_Betton.Size = new System.Drawing.Size(146, 39);
            this.Delete_Exercise_Betton.TabIndex = 4;
            this.Delete_Exercise_Betton.Text = "Удалить";
            this.Delete_Exercise_Betton.UseVisualStyleBackColor = true;
            this.Delete_Exercise_Betton.Click += new System.EventHandler(this.Delete_Exercise_Betton_Click);
            // 
            // Exercise_dataGridView
            // 
            this.Exercise_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Exercise_dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.Exercise_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Exercise_dataGridView.Location = new System.Drawing.Point(6, 19);
            this.Exercise_dataGridView.Name = "Exercise_dataGridView";
            this.Exercise_dataGridView.Size = new System.Drawing.Size(624, 287);
            this.Exercise_dataGridView.TabIndex = 5;
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(668, 425);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Trainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивный клуб";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trainer_FormClosing_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nutrition_programm_dataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cometition_trainer_dataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sports_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programm_training_dataGridView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exercise_dataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView programm_training_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete_Exercise_Betton;
        private System.Windows.Forms.DataGridView Exercise_dataGridView;
    }
}