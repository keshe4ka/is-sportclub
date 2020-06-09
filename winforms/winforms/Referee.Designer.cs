namespace winforms
{
    partial class Referee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Referee));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kind_of_sport_tabpage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sports_dataGridView = new System.Windows.Forms.DataGridView();
            this.competition_tabpage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.competitions_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.kind_of_sport_tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sports_dataGridView)).BeginInit();
            this.competition_tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitions_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.kind_of_sport_tabpage);
            this.tabControl1.Controls.Add(this.competition_tabpage);
            this.tabControl1.Location = new System.Drawing.Point(9, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // kind_of_sport_tabpage
            // 
            this.kind_of_sport_tabpage.BackColor = System.Drawing.Color.SteelBlue;
            this.kind_of_sport_tabpage.Controls.Add(this.pictureBox1);
            this.kind_of_sport_tabpage.Controls.Add(this.sports_dataGridView);
            this.kind_of_sport_tabpage.Location = new System.Drawing.Point(4, 22);
            this.kind_of_sport_tabpage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kind_of_sport_tabpage.Name = "kind_of_sport_tabpage";
            this.kind_of_sport_tabpage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kind_of_sport_tabpage.Size = new System.Drawing.Size(680, 327);
            this.kind_of_sport_tabpage.TabIndex = 1;
            this.kind_of_sport_tabpage.Text = "Виды спорта";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sports_dataGridView
            // 
            this.sports_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sports_dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.sports_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sports_dataGridView.Location = new System.Drawing.Point(9, 9);
            this.sports_dataGridView.Name = "sports_dataGridView";
            this.sports_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sports_dataGridView.Size = new System.Drawing.Size(367, 305);
            this.sports_dataGridView.TabIndex = 0;
            // 
            // competition_tabpage
            // 
            this.competition_tabpage.BackColor = System.Drawing.Color.SteelBlue;
            this.competition_tabpage.Controls.Add(this.label1);
            this.competition_tabpage.Controls.Add(this.search_textbox);
            this.competition_tabpage.Controls.Add(this.addButton);
            this.competition_tabpage.Controls.Add(this.deleteButton);
            this.competition_tabpage.Controls.Add(this.searchButton);
            this.competition_tabpage.Controls.Add(this.competitions_dataGridView);
            this.competition_tabpage.Location = new System.Drawing.Point(4, 22);
            this.competition_tabpage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.competition_tabpage.Name = "competition_tabpage";
            this.competition_tabpage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.competition_tabpage.Size = new System.Drawing.Size(680, 327);
            this.competition_tabpage.TabIndex = 0;
            this.competition_tabpage.Text = "Соревнования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(248, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название соревнования:";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(382, 291);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(176, 20);
            this.search_textbox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(14, 278);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 40);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(109, 278);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(575, 278);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 40);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // competitions_dataGridView
            // 
            this.competitions_dataGridView.AllowUserToAddRows = false;
            this.competitions_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.competitions_dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.competitions_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competitions_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.competitions_dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.competitions_dataGridView.Name = "competitions_dataGridView";
            this.competitions_dataGridView.RowTemplate.Height = 24;
            this.competitions_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.competitions_dataGridView.Size = new System.Drawing.Size(680, 266);
            this.competitions_dataGridView.TabIndex = 0;
            // 
            // Referee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(707, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Referee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Referee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Referee_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.kind_of_sport_tabpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sports_dataGridView)).EndInit();
            this.competition_tabpage.ResumeLayout(false);
            this.competition_tabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitions_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage competition_tabpage;
        private System.Windows.Forms.TabPage kind_of_sport_tabpage;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView competitions_dataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView sports_dataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
    }
}