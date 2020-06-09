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
    public partial class AddUser : Form

    {
        private readonly MainForm User1;
        //Referee addCompetition in ()
        public AddUser(MainForm addUser)
        {
           
            InitializeComponent();
            AddUserLoad();
            User1 = addUser;
        }
        //добавление роли пользовтелю
        private void AddUserLoad()
        {
            try
            {
                DB db = new DB();
                string selectQuery = "SELECT DISTINCT Role FROM sportclub_v2.user ";
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    role_combobox.Items.Add(reader.GetString("Role"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //кнопка добавления пользователя
        private void addUserButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            if (role_combobox.Text == "")
            {
                MessageBox.Show("Вы не внесли значения!");
            }
            else
            {
                String query = "INSERT INTO user(second_name, name, patronymic, login, password, Role) " +
                "VALUES(@second_name, @name, @patronymic, @login, @password, @Role)";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.Add("@second_name", MySqlDbType.VarChar).Value = secondname_textbox.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_textbox.Text;
                command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = patronymic_textbox.Text;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_textbox.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_textbox.Text;
                command.Parameters.Add("@Role", MySqlDbType.VarChar).Value = role_combobox.Text;
                MySqlDataReader reader = command.ExecuteReader();
                db.closeConnection();
                MessageBox.Show("Запись добавлена!");

                //очистка полей после ввода
                if (secondname_textbox.Text != " ")
                {
                    secondname_textbox.Text = " ";
                    name_textbox.Text = " ";
                    patronymic_textbox.Text = " ";
                    login_textbox.Text = " ";
                    password_textbox.Text = " ";
                    role_combobox.Text = " ";
                }

                //вызвали функцию обновления
                User1.RefreshGrid();
            }
        }
    }
}
