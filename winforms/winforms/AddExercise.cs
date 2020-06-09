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
    public partial class AddExercise : Form
    {
        private readonly Trainer Exercise1;
        public AddExercise(Trainer addExercise)
        {
            InitializeComponent();

            Exercise1 = addExercise;
        }

        //добавляем упражнение
        private void addExerciseButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            if (nameExercise_textBox.Text == "")
            {
                MessageBox.Show("Вы не внесли значения!");
            }
            else
            {
                String query = "INSERT INTO exercise(name , description) " +
                "VALUES(@name, @description)";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameExercise_textBox.Text;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = discription_textBox.Text;
                MySqlDataReader reader = command.ExecuteReader();
                db.closeConnection();
                MessageBox.Show("Запись добавлена!");

                //очистка полей после ввода
                if (nameExercise_textBox.Text != " ")
                {
                    nameExercise_textBox.Text = " ";
                    discription_textBox.Text = " ";
                }

                //вызвали функцию обновления
                Exercise1.RefreshGridExercise();
            }
        }
    }
}
