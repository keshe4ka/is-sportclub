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
using System.Security.Cryptography.X509Certificates;

namespace winforms
{
    public partial class Sportsman : Form
    {
        public Sportsman()
        {
            InitializeComponent();
            LoadCompetitionsData();
            LoadSportsmanData();
            LoadNutritionData();
            LoadTreningProgrammnData();
            LoadSportsData();
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

        //закртытие приложения
        private void Sportsman_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            cometition_sportsman_dataGridView.DataSource = bs;
            db.closeConnection();
        }
        //Подключаемся к таблице спортсменов
        private void LoadSportsmanData()
        {
            {
                DB db = new DB();
                db.openConnection();
                String query = "SELECT * FROM sportsman";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
                DataSet data = new DataSet();
                adapter.Fill(data);
                BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
                sportsman_dataGridView.DataSource = bs;
                db.closeConnection();
            }

        }
        //поиск нужного спорсмена
        private void searchSportsman_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= sportsman_dataGridView.Rows.Count - 1; i++)
            {
                if (sportsman_dataGridView.Rows[i].Cells[1].FormattedValue.ToString().Contains(searchsportsmen_textBox.Text))
                {
                    sportsman_dataGridView.Rows[i].Selected = true;
                }
                else
                {
                    sportsman_dataGridView.Rows[i].Selected = false;
                }
            }
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
            programm_nutrition_dataGridView.DataSource = bs;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (gender_comboBox.Text == "")
            {
                MessageBox.Show("Вы не указали пол!");
            }
            else if (weight_textBox.Text == "")
            {
                MessageBox.Show("Вы не указали вес!");
            }
            else if (height_textBox.Text == "")
            {
                MessageBox.Show("Вы не указали рост!");
            }
            else if (age_textBox.Text == "")
            {
                MessageBox.Show("Вы не указали возраст!");
            }
            else if (activity_comboBox.Text == "")
            {
                MessageBox.Show("Вы не указали уровень актитвности!");
            }
            else
            {
                Calculation();
            }

        }
        public void Calculation()
        {
            int weight = Convert.ToInt32(weight_textBox.Text);
            int height = Convert.ToInt32(height_textBox.Text);
            int age = Convert.ToInt32(age_textBox.Text);
            double kalorii = 0;
            if (age >= 13 && age <= 80)
            {
                if (gender_comboBox.Text == "Мужской")
                {
                    kalorii = 10 * weight + 6.25 * height + 5 * age + 5;
                }
                else
                {
                    kalorii = 10 * weight + 6.25 * height + 5 * age - 161;
                }
                switch ((string)activity_comboBox.Text)
                {
                    case "Отсутствие физической нагрузки": kalorii *= 1.2; break;
                    case "3 раза в неделю": kalorii *= 1.38; break;
                    case "5 раз в недедлю": kalorii *= 1.55; break;
                    case "Каждый день": kalorii *= 1.73; break;
                }
                First_textBox.Text = kalorii.ToString();
                Second_textBox.Text = (kalorii - 350).ToString();
                third_textBox.Text = (kalorii - 950).ToString();
            }
            else {
                MessageBox.Show("Допутсимый возраст от 13 до 80 лет!");
            }
        }
    }
}
