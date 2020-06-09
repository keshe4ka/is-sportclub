using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
            LoadCompetitionsData();
            LoadNutritionData();
            LoadTreningProgrammnData();
            LoadSportsData();
            LoadData();
        }
        //Подключаемся к таблице спортсменов
        private void LoadData()
        {
            {
                DB db = new DB();
                db.openConnection();
                String query = "SELECT sportsman.id, sportsman.User_id, user.second_name, user.name FROM sportclub_v2.sportsman, sportclub_v2.user WHERE sportsman.User_id = user.id";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
                DataSet data = new DataSet();
                adapter.Fill(data);
                BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
                dataGridView2.DataSource = bs;
                db.closeConnection();
            }

        }
        //Подключаемся к таблице спортсменов тренера
        private void LoadDataMySportsmen()
        {
            {
                DB db = new DB();
                db.openConnection();
                String query = ("SELECT sportsman.id, sportsman.birthday,sportsman.User_id FROM sportsman, trainer, user WHERE trainer.User_id = user.id and sportsman.Trainer_id = trainer.id  and  user.login = ('" + Program.appId + "')");
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
                DataSet data = new DataSet();
                adapter.Fill(data);
                BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
                dataGridView2.DataSource = bs;
                db.closeConnection();
            }

        }
        //Показываем всех спортсменов
        private void AllSportsmanButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        public void RefreshGrid()
        {
            LoadData();
        }
        //показываем спортсменов тренера
        private void MuSportsmanButton_Click(object sender, EventArgs e)
        {
            RefreshGridMy();
        }
        public void RefreshGridMy()
        {
            LoadDataMySportsmen();
        }
        //Добавления тренером новых спортсменов
        private void AddSportsmanButton_Click(object sender, EventArgs e)
        {
            AddSportsman addSportsman = new AddSportsman(this);
            addSportsman.Show();
        }
        //Зыкрыть все приложение
        private void Trainer_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //прогружаем данные видов спорта
        private void LoadSportsData()
        {
            DB db = new DB();
            db.openConnection();
            String query = "SELECT * FROM kind_of_sport";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            sports_dataGridView.DataSource = bs;
            db.closeConnection();
        }
        //Подключаемся к таблице соревнований
        private void LoadCompetitionsData()
        {
            DB db = new DB();
            db.openConnection();
            String query = "SELECT * FROM competition";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            cometition_trainer_dataGridView.DataSource = bs;
            db.closeConnection();
        }
        //Подключаемся к таблице программ питания
        private void LoadNutritionData()
        {
            DB db = new DB();
            db.openConnection();
            String query = "SELECT * FROM nutrition_program";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            nutrition_programm_dataGridView.DataSource = bs;
            db.closeConnection();
        }
        //Подключаемся к таблице программ тренировок
        private void LoadTreningProgrammnData()
        {
            DB db = new DB();
            db.openConnection();
            String query = "SELECT * FROM training_programm";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            programm_training_dataGridView.DataSource = bs;
            db.closeConnection();
        }
        //Поиск нужного тренеру соревнования
        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= cometition_trainer_dataGridView.Rows.Count - 1; i++)
            {
                if (cometition_trainer_dataGridView.Rows[i].Cells[1].FormattedValue.ToString().Contains(search_textbox.Text))
                {
                    cometition_trainer_dataGridView.Rows[i].Selected = true;
                }
                else
                {
                    cometition_trainer_dataGridView.Rows[i].Selected = false;
                }
            }
        }
        //Поиск нужного спорсмена
        private void searchSportsman_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                if (dataGridView2.Rows[i].Cells[1].FormattedValue.ToString().Contains(searchsportsmen_textBox.Text))
                {
                    dataGridView2.Rows[i].Selected = true;
                }
                else
                {
                    dataGridView2.Rows[i].Selected = false;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                //кидаем проверочку
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удалить данные", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DB db = new DB();
                    db.openConnection();
                    int rowIdToDelete = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                    MySqlCommand command = new MySqlCommand("DELETE FROM sportsman WHERE id = '" + rowIdToDelete + "'", db.getConnection());
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
                        RefreshGridMy();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }


}
