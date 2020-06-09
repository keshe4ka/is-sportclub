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
    public partial class AddSport : Form
    {
        private readonly MainForm Sport1;
        //Referee addCompetition in ()
        public AddSport(MainForm addSport)
        {
            InitializeComponent();           
            Sport1 = addSport;
        }
               
        //добавляем вид спорта
        private void addUserButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            if (namesport_textbox.Text == "")
            {
                MessageBox.Show("Вы не внесли значения!");
            }
            else
            {
                String query = "INSERT INTO kind_of_sport(name, world_record, date_of_record) " +
                "VALUES(@name, @world_record, @date_of_record)";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = namesport_textbox.Text;
                command.Parameters.Add("@world_record", MySqlDbType.VarChar).Value = worldrecord_textbox.Text;
                command.Parameters.Add("@date_of_record", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
                MySqlDataReader reader = command.ExecuteReader();
                db.closeConnection();
                MessageBox.Show("Запись добавлена!");

                //очистка полей после ввода
                if (namesport_textbox.Text != " ")
                {
                    namesport_textbox.Text = " ";
                    worldrecord_textbox.Text = " ";
                }

                //вызвали функцию обновления
                Sport1.RefreshGridSport();
            }
        }
    }
}
