using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class Referee : Form
    {       
        public Referee()
        {
            InitializeComponent();
            LoadData();
            LoadSportsData();
        }

        //функция для обнолвения таблички с данными (я не придумал ничего лучше, чем снова вызывать функцию прогрузки)
        public void RefreshGrid()
        {
            LoadData();            
        }

        //прогружаем данные соревнований
        private void LoadData()
        {            
            DB db = new DB();
            db.openConnection();
            String query = "SELECT competition.id, competition.Name AS `Название`, kind_of_sport.name AS `Вид спорта`, competition.Result AS `Результат`, competition.Place AS `Место`, user.second_name AS `Фамилия`, user.name AS `Имя`, competition.Date AS `Дата проведения`, competition.Referee_id AS `id Судьи` " +
                " FROM `competition`, `kind_of_sport`, `user`, `sportsman` " +
                "WHERE competition.Kind_of_sport_id = kind_of_sport.id" +
                " and sportsman.id = competition.Sportsman_id" +
                " and sportsman.User_id = user.id";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            competitions_dataGridView.DataSource = bs;
            db.closeConnection();
        }

        //прогружаем данные видов спорта
        private void LoadSportsData()
        {
            DB db = new DB();
            db.openConnection();
            String query = "SELECT id, name AS `Название`, world_record AS `Мировой рекорд`, date_of_record AS `Дата рекорда` FROM kind_of_sport";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            sports_dataGridView.DataSource = bs;
            db.closeConnection();
        }


        //закрываем формочку
        private void Referee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //тык на кнопку и вызывем формочку
        private void addButton_Click(object sender, EventArgs e)
        {           
            AddCompetition addCompetition = new AddCompetition(this);
            addCompetition.Show();           
        }

        //удаляем
        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in competitions_dataGridView.SelectedRows)
            {
                //кидаем проверочку
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удалить данные", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DB db = new DB();
                    db.openConnection();
                    int rowIdToDelete = Convert.ToInt32(competitions_dataGridView.SelectedRows[0].Cells[0].Value);
                    MySqlCommand command = new MySqlCommand("DELETE FROM competition WHERE id = '" + rowIdToDelete + "'", db.getConnection());
                    try
                    {
                        db.openConnection();
                        MySqlDataReader dataReader = command.ExecuteReader();
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        db.closeConnection();
                        RefreshGrid();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                   
                }                
            }
        }

        //поиск соревнования
        private void searchButton_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i <= competitions_dataGridView.Rows.Count - 1; i++)
            {
                if (competitions_dataGridView.Rows[i].Cells[1].FormattedValue.ToString().Contains(search_textbox.Text))
                {
                    competitions_dataGridView.Rows[i].Selected = true;
                }
                else
                {
                    competitions_dataGridView.Rows[i].Selected = false;
                }
            }
        }
    }
}
