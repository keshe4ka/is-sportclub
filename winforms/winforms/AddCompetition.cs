using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class AddCompetition : Form
    {
        private readonly Referee Referee1;
        //Referee addCompetition in ()
        public AddCompetition(Referee addCompetition)
        {
            InitializeComponent();
            AddCompetitionLoad();
            AddSportsmanIdLoad();
            AddRefereeIdLoad();
            Referee1 = addCompetition;
        }

        //заполняем комбобокс для спорта
        private void AddCompetitionLoad ()
        {
            try
            {
                DB db = new DB();                
                string selectQuery = "SELECT * FROM sportclub_v2.kind_of_sport";
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sport_combobox.Items.Add(reader.GetString("name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //заполняем комбобокс для id спортсменов
        private void AddSportsmanIdLoad()
        {
            try
            {
                DB db = new DB();
                string selectQuery = "SELECT * FROM sportclub_v2.sportsman";
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    idsportsman_comboBox.Items.Add(reader.GetString("id"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //заполняем комбобокс для id судей
        private void AddRefereeIdLoad()
        {
            try
            {
                DB db = new DB();
                string selectQuery = "SELECT * FROM sportclub_v2.referee";
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    idreferee_comboBox.Items.Add(reader.GetString("id"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //нажали на кнопку ок и перегнали данные из ввода
        private void addButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            //этот костыль нужен для того, чтобы в комбобоксе отображалось название вида спорта, а в sql запрос отправлся его id
            int sport_id;
            string kind_of_sport = sport_combobox.Text;
            String ko_sport = "SELECT id FROM kind_of_sport WHERE kind_of_sport.name = '" + kind_of_sport + "'";
            MySqlCommand command_sport = new MySqlCommand(ko_sport, db.getConnection());
            MySqlDataReader dataReader = command_sport.ExecuteReader();
            dataReader.Read();
            sport_id = Convert.ToInt32(dataReader["id"]);
            db.closeConnection();
            //конец костыля
            //прога падала, если ничего не ввести и нажать кнопку ок, поэтому я прописал это условие
            if (sport_combobox.Text == "")
            {
                MessageBox.Show("Вы не внесли значения!");                
            }
            else
            {                
                db.openConnection();
                String query = "INSERT INTO competition(Name, Kind_of_sport_id, Result, Place, Sportsman_id, Date, Referee_id) " +
                "VALUES(@name, @kind_of_sport, @result, @place, @Sportsman_id, @date, @Referee_id)";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_textbox.Text;
                command.Parameters.Add("@kind_of_sport", MySqlDbType.VarChar).Value = sport_id; //переменная из костыля
                command.Parameters.Add("@result", MySqlDbType.VarChar).Value = result_textbox.Text;
                command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place_textbox.Text;
                command.Parameters.Add("@Sportsman_id", MySqlDbType.VarChar).Value = idsportsman_comboBox.Text;
                command.Parameters.Add("@date", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
                command.Parameters.Add("@Referee_id", MySqlDbType.VarChar).Value = idreferee_comboBox.Text;
                MySqlDataReader reader = command.ExecuteReader();
                db.closeConnection();
                MessageBox.Show("Запись добавлена!");

                //очистка полей после ввода
                if (name_textbox.Text != " ")
                {
                    name_textbox.Text = " ";
                    sport_combobox.Text = " ";
                    result_textbox.Text = " ";
                    place_textbox.Text = " ";
                    idsportsman_comboBox.Text = " ";
                    idreferee_comboBox.Text = " ";
                }

                //вызвали функцию обновления
                Referee1.RefreshGrid();
            }
            
            
        }

        //на кнопку отмены просто закрываем форму
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
