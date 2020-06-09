namespace winforms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.search_secondname_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.export_button = new System.Windows.Forms.Button();
            this.DeliteSportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSportButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sports_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sports_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.search_button);
            this.tabPage1.Controls.Add(this.search_secondname_textBox);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(413, 393);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск по фамилии:";
            // 
            // search_button
            // 
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_button.Location = new System.Drawing.Point(664, 386);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(102, 28);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_secondname_textBox
            // 
            this.search_secondname_textBox.Location = new System.Drawing.Point(520, 391);
            this.search_secondname_textBox.Name = "search_secondname_textBox";
            this.search_secondname_textBox.Size = new System.Drawing.Size(138, 20);
            this.search_secondname_textBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(762, 374);
            this.dataGridView1.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(152, 386);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(142, 28);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить пользователя";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(6, 386);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 28);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить пользователя";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.export_button);
            this.tabPage2.Controls.Add(this.DeliteSportButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.AddSportButton);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.sports_dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Виды спорта";
            // 
            // export_button
            // 
            this.export_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.export_button.Location = new System.Drawing.Point(608, 388);
            this.export_button.Margin = new System.Windows.Forms.Padding(2);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(156, 28);
            this.export_button.TabIndex = 9;
            this.export_button.Text = "Выгрузить данные в Excel ";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // DeliteSportButton
            // 
            this.DeliteSportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliteSportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeliteSportButton.Location = new System.Drawing.Point(302, 388);
            this.DeliteSportButton.Name = "DeliteSportButton";
            this.DeliteSportButton.Size = new System.Drawing.Size(119, 28);
            this.DeliteSportButton.TabIndex = 8;
            this.DeliteSportButton.Text = "Удалить";
            this.DeliteSportButton.UseVisualStyleBackColor = true;
            this.DeliteSportButton.Click += new System.EventHandler(this.DeliteSportButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // AddSportButton
            // 
            this.AddSportButton.AutoEllipsis = true;
            this.AddSportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddSportButton.Location = new System.Drawing.Point(4, 388);
            this.AddSportButton.Name = "AddSportButton";
            this.AddSportButton.Size = new System.Drawing.Size(123, 28);
            this.AddSportButton.TabIndex = 4;
            this.AddSportButton.Text = "Добавить";
            this.AddSportButton.UseVisualStyleBackColor = true;
            this.AddSportButton.Click += new System.EventHandler(this.AddSportButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // sports_dataGridView
            // 
            this.sports_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sports_dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.sports_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sports_dataGridView.Location = new System.Drawing.Point(4, 6);
            this.sports_dataGridView.Name = "sports_dataGridView";
            this.sports_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sports_dataGridView.Size = new System.Drawing.Size(418, 375);
            this.sports_dataGridView.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(783, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивный клуб";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sports_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search_secondname_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView sports_dataGridView;
        private System.Windows.Forms.Button DeliteSportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddSportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button export_button;
    }
}