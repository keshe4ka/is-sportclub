using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        enum Role { Admin, Sportsman, Trainer, Referee, Failed }

        //проверка на наличие пользователя
        static Role GetRole(string login, string password)
        {
            Role role = Role.Failed;
            DB db = new DB();           
            MySqlCommand command = new MySqlCommand("Select `Role` From `user` WHERE `login`=@login AND `password`=@password", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            db.openConnection();
            MySqlDataReader dataReader = command.ExecuteReader();
            using (dataReader)
            {
                if (dataReader.Read())
                {
                    switch ((string)dataReader["Role"])
                    {
                        case "Admin": role = Role.Admin; break;                      
                        case "Trainer": role = Role.Trainer; break;
                        case "Referee": role = Role.Referee; break;
                        case "Sportsman": role = Role.Sportsman; break;
                    }
                }
            }
            return role;
            
        }

        //тыкнули на кнопку и вошли
        private void login_button_Click(object sender, EventArgs e)
        {
            Program.appId = login_textbox.Text;
            Role role = GetRole(login_textbox.Text, password_textbox.Text);
            if (role == Role.Failed)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else
            {
                if (role == Role.Admin)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else if (role == Role.Trainer)
                {
                    this.Hide();
                    Trainer TrainerForm = new Trainer();
                    TrainerForm.Show();
                }
                else if (role == Role.Referee)
                {
                    this.Hide();
                    Referee RefereeForm = new Referee();
                    RefereeForm.Show();                    
                }
                else if (role == Role.Sportsman)
                {
                    this.Hide();
                    Sportsman SportsmanForm = new Sportsman();
                    SportsmanForm.Show();
                }
            }
        }

        //закрытие проги когда тык на крестик
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



    }
}
