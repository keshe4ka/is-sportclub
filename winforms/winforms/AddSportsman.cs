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
    public partial class AddSportsman : Form
    {
        private readonly Trainer Sportsman1;
        public AddSportsman(Trainer addSportsman)
        {
            InitializeComponent();
            showTrainerId();
            Sportsman1 = addSportsman;
        }

        //Заполняем комбобокс спортсмена
        //private void AddSportsmanLoad()
        //{
        //    try
        //    {                
        //        DB db = new DB();
        //        string selectQuery = "SELECT id FROM sportsman";
        //        db.openConnection();
        //        MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
        //        MySqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            NameSportsman.Items.Add(reader.GetString("id"));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }            
        //}


        //вывод id тренера
        private void showTrainerId()
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand getid = new MySqlCommand("SELECT trainer.id FROM user, trainer WHERE  trainer.User_id = '" + Program.appId + "'", db.getConnection());
            label5.Text = getid.ExecuteScalar().ToString();
            db.closeConnection();
        }

        //перегоняем данные
        private void addSportsmanButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            if (textBox2.Text == "")
            {
                MessageBox.Show("Вы не внесли значения!");
            }
            else
            {                
                String query = "INSERT INTO sportsman(birthday,sports_category, User_id, Trainer_id ) " +
                "VALUES(@birthday, @sports_category, @User_id, @Trainer_id )";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                
               
                command.Parameters.Add("@birthday", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
                command.Parameters.Add("@sports_category", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@User_id", MySqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@Trainer_id", MySqlDbType.VarChar).Value = label5.Text;
                MySqlDataReader reader = command.ExecuteReader();
                db.closeConnection();
                MessageBox.Show("Запись добавлена!");

                //очистка полей после ввода
                if (textBox2.Text != " ")
                {
                    textBox2.Text = " ";
                }

                //вызвали функцию обновления
                Sportsman1.RefreshGrid();
                Sportsman1.RefreshGridMy();
            }
        }
    }
}
