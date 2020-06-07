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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.competition_tabpage = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.competitions_dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_competition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind_of_sport_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sportsman_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kind_of_sport_tabpage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.competition_tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitions_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.competition_tabpage);
            this.tabControl1.Controls.Add(this.kind_of_sport_tabpage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // competition_tabpage
            // 
            this.competition_tabpage.Controls.Add(this.searchButton);
            this.competition_tabpage.Controls.Add(this.deleteButton);
            this.competition_tabpage.Controls.Add(this.changeButton);
            this.competition_tabpage.Controls.Add(this.addButton);
            this.competition_tabpage.Controls.Add(this.competitions_dataGridView);
            this.competition_tabpage.Location = new System.Drawing.Point(4, 25);
            this.competition_tabpage.Name = "competition_tabpage";
            this.competition_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.competition_tabpage.Size = new System.Drawing.Size(863, 397);
            this.competition_tabpage.TabIndex = 0;
            this.competition_tabpage.Text = "Соревнования";
            this.competition_tabpage.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(735, 342);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 49);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(262, 342);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 49);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(134, 342);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(122, 49);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(6, 342);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 49);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // competitions_dataGridView
            // 
            this.competitions_dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.competitions_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competitions_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_competition,
            this.Kind_of_sport_id,
            this.Result,
            this.Place,
            this.Sportsman_id,
            this.Date,
            this.Referee_id});
            this.competitions_dataGridView.Location = new System.Drawing.Point(15, 0);
            this.competitions_dataGridView.Name = "competitions_dataGridView";
            this.competitions_dataGridView.RowTemplate.Height = 24;
            this.competitions_dataGridView.Size = new System.Drawing.Size(845, 332);
            this.competitions_dataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name_competition
            // 
            this.name_competition.HeaderText = "Name";
            this.name_competition.Name = "name_competition";
            // 
            // Kind_of_sport_id
            // 
            this.Kind_of_sport_id.HeaderText = "Kind_of_sport_id";
            this.Kind_of_sport_id.Name = "Kind_of_sport_id";
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            // 
            // Place
            // 
            this.Place.HeaderText = "Place";
            this.Place.Name = "Place";
            // 
            // Sportsman_id
            // 
            this.Sportsman_id.HeaderText = "Sportsman_id";
            this.Sportsman_id.Name = "Sportsman_id";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Referee_id
            // 
            this.Referee_id.HeaderText = "Referee_id";
            this.Referee_id.Name = "Referee_id";
            // 
            // kind_of_sport_tabpage
            // 
            this.kind_of_sport_tabpage.Location = new System.Drawing.Point(4, 25);
            this.kind_of_sport_tabpage.Name = "kind_of_sport_tabpage";
            this.kind_of_sport_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.kind_of_sport_tabpage.Size = new System.Drawing.Size(863, 397);
            this.kind_of_sport_tabpage.TabIndex = 1;
            this.kind_of_sport_tabpage.Text = "Виды спорта";
            this.kind_of_sport_tabpage.UseVisualStyleBackColor = true;
            // 
            // Referee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Referee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Referee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Referee_FormClosing);
            this.Load += new System.EventHandler(this.Referee_Load);
            this.tabControl1.ResumeLayout(false);
            this.competition_tabpage.ResumeLayout(false);
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
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_competition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kind_of_sport_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sportsman_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referee_id;
    }
}