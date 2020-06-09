using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace winforms
{
    public partial class AddTrainingProgramm : Form
    {
        private readonly Trainer Programm1;
        public AddTrainingProgramm(Trainer addTrainingProgramm)
        {
            InitializeComponent();
            AddProgrammLoad();
            Programm1 = addTrainingProgramm;
        }

        //заполнение комбокса упражнений
        private void AddProgrammLoad()
        {
            try
            {
                DB db = new DB();
                string selectQuery = "SELECT * FROM sportclub_v2.exercise";
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Exercise_id_comboBox.Items.Add(reader.GetString("id"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //кнопка добавление новой записи  тренировчной программы
        private void addSportsmanButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            if (number_of_times_textBox.Text == "")
            {
                MessageBox.Show("Вы не внесли значения!");
            }
            else
            {
                String query = "INSERT INTO training_programm(number_of_times , lead_time, Exercise_id) " +
                "VALUES(@number_of_times, @lead_time, @Exercise_id)";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.Add("@number_of_times", MySqlDbType.VarChar).Value = number_of_times_textBox.Text;
                command.Parameters.Add("@lead_time", MySqlDbType.VarChar).Value = lead_time_textBox.Text;
                command.Parameters.Add("@Exercise_id", MySqlDbType.VarChar).Value = Exercise_id_comboBox.Text;
                MySqlDataReader reader = command.ExecuteReader();
                db.closeConnection();
                MessageBox.Show("Запись добавлена!");

                //очистка полей после ввода
                if (number_of_times_textBox.Text != " ")
                {
                    number_of_times_textBox.Text = " ";
                    lead_time_textBox.Text = " ";
                }

                //вызвали функцию обновления
                Programm1.RefreshGridProgramm();
            }

            
        }
    }
}
