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
            LoadExerciseData();
            LoadSportsData();
            LoadData();
        }
        private int kostyl; //костыль разработан для удаления спорстменов, чтоб тренер мог удалять ток своих

        //Подключаемся к таблице спортсменов
        private void LoadData()
        {
           
            DB db = new DB();
            db.openConnection();
            string sportsman_string = "Sportsman";
            String query = "SELECT user.id AS `id Пользователя`, user.second_name AS `Фамилия`, user.name AS `Имя`, user.patronymic AS `Отчество` " +
                "FROM user " +
                "WHERE user.Role = ('" + sportsman_string + "')";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            dataGridView2.DataSource = bs;
            db.closeConnection();
           

        }

        //Подключаемся к таблице спортсменов тренера
        private void LoadDataMySportsmen()
        {          
            DB db = new DB();
            db.openConnection();
            String query = ("SELECT sportsman.User_id AS `id Пользователя`, sportsman.id AS `id Спортсмена`, sportsman.birthday AS `Дата рождения`, user.second_name AS `Фамилия`, user.name AS `Имя`" +
                "FROM sportclub_v2.sportsman, sportclub_v2.trainer, sportclub_v2.user " +
                "WHERE sportsman.Trainer_id = trainer.id  " +
                "and  trainer.User_id = ('" + Program.appId + "')" +
                "and sportsman.User_id = user.id") ;                 
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            dataGridView2.DataSource = bs;
            db.closeConnection();             
        }

        //Показываем всех спортсменов
        private void AllSportsmanButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            kostyl = 1;
        }

        //  обновление таблицы спорсмены
        public void RefreshGrid()
        {
            LoadData();
        }

        //показываем спортсменов тренера
        private void MuSportsmanButton_Click(object sender, EventArgs e)
        {
            RefreshGridMy();
            kostyl = 0;
        }
        //  обновление таблицы мои спортсмены
        public void RefreshGridMy()
        {
            LoadDataMySportsmen();
        }

        //  обновление таблицы программ тренировок
        public void RefreshGridProgramm()
        {
            LoadTreningProgrammnData();
        }

        //  обновление таблицы упражнений
        public void RefreshGridExercise()
        {
            LoadExerciseData();
            LoadNutritionData();
        }
        //  обновление таблицы питания
        public void RefreshGridNutrition()
        {
            LoadNutritionData();
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
            String query = "SELECT id, name AS `Название`, world_record AS `Мировой рекорд`, date_of_record AS `Дата рекорда` FROM kind_of_sport";
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
            String query = "SELECT competition.Name AS `Название`, kind_of_sport.name AS `Вид спорта`, competition.Result AS `Результат`, competition.Place AS `Место`, user.second_name AS `Фамилия`, user.name AS `Имя`, competition.Date AS `Дата проведения`, competition.Referee_id AS `id Судьи` " +
                " FROM `competition`, `kind_of_sport`, `user`, `sportsman` " +
                "WHERE competition.Kind_of_sport_id = kind_of_sport.id" +
                " and sportsman.id = competition.Sportsman_id" +
                " and sportsman.User_id = user.id";
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
            String query = "SELECT nutrition_program.id, nutrition_program.Trainer_id AS `id Тренера`, nutrition_program.wish_weight AS `Желаемый вес`, nutrition_program.Sportsman_id AS `id Спортсмена`, user.second_name AS `Фамилия`, user.name AS `Имя` " +
                "FROM nutrition_program, user, sportsman " +
                "WHERE sportsman.id = nutrition_program.Sportsman_id " +
                "and sportsman.User_id = user.id  ";
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
            String query = "SELECT training_programm.id, training_programm.number_of_times AS 'Количетсво', training_programm.lead_time AS 'Время выполнения', training_programm.Exercise_id AS 'id упражнения' FROM training_programm, exercise WHERE training_programm.Exercise_id = exercise.id";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            programm_training_dataGridView.DataSource = bs;
            db.closeConnection();
        }
        //Подключаемся к таблице упражнений
        private void LoadExerciseData()
        {
            DB db = new DB();
            db.openConnection();
            String query = "SELECT id, name AS 'Название', description AS 'Описание'  FROM exercise";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            Exercise_dataGridView.DataSource = bs;
            db.closeConnection();
        }

        //Поиск нужного тренеру соревнования
        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= cometition_trainer_dataGridView.Rows.Count - 1; i++)
            {
                if (cometition_trainer_dataGridView.Rows[i].Cells[0].FormattedValue.ToString().Contains(search_textbox.Text))
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

        //Удаление спортсмена
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //в дело идет костыль - при клике на "показать моих спорстменов", костылю дается ноль
            //при клике на "показать всех", дается 1
            //разрешим удалить только при нуле, иначе попросим нажать на кнопку "показать своих спортсменов"
            if (kostyl == 0)
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
                        String query = ("DELETE FROM sportsman WHERE sportsman.id = '" + rowIdToDelete + "' ");
                        MySqlCommand command = new MySqlCommand(query, db.getConnection());
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
            else
            {
                MessageBox.Show("Вы можете удалять только при отображении ваших спортсменов!");
            }
            
        }

        //  кнопка добавления программы тренировок
        private void addProgramm_training_Click(object sender, EventArgs e)
        {
            AddTrainingProgramm addTrainingProgramm = new AddTrainingProgramm(this);
            addTrainingProgramm.Show();
        }

        //  кнопка удаления программы тренировок
        private void delete_programm_training_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in programm_training_dataGridView.SelectedRows)
            {
                //кидаем проверочку
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удалить данные", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DB db = new DB();
                    db.openConnection();
                    int rowIdToDelete = Convert.ToInt32(programm_training_dataGridView.SelectedRows[0].Cells[0].Value);
                    MySqlCommand command = new MySqlCommand("DELETE FROM training_programm WHERE id = '" + rowIdToDelete + "'", db.getConnection());
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
                        RefreshGridProgramm();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        //  кнопка добавления упражнения
        private void button1_Click(object sender, EventArgs e)
        {
            AddExercise addExercise = new AddExercise(this);
            addExercise.Show();
        }

        //  кнопка удаления упражнения
        private void Delete_Exercise_Betton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Exercise_dataGridView.SelectedRows)
            {
                //кидаем проверочку
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удалить данные", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DB db = new DB();
                    db.openConnection();
                    int rowIdToDelete = Convert.ToInt32(Exercise_dataGridView.SelectedRows[0].Cells[0].Value);
                    MySqlCommand command = new MySqlCommand("DELETE FROM exercise WHERE id = '" + rowIdToDelete + "'", db.getConnection());
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
                        RefreshGridExercise();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        //кнопка добавления программы питания
        private void add_nutrition_programm_Click(object sender, EventArgs e)
        {
            AddNutritionProgramm addNutritionProgramm = new AddNutritionProgramm(this);
            addNutritionProgramm.Show();
        }

        //кнопка удаления программы питания
        private void delete_nutrition_programm_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in nutrition_programm_dataGridView.SelectedRows)
            {
                //кидаем проверочку
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удалить данные", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DB db = new DB();
                    db.openConnection();
                    int rowIdToDelete = Convert.ToInt32(nutrition_programm_dataGridView.SelectedRows[0].Cells[0].Value);
                    MySqlCommand command = new MySqlCommand("DELETE FROM nutrition_program WHERE id = '" + rowIdToDelete + "'", db.getConnection());
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
                        RefreshGridNutrition();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }


}
