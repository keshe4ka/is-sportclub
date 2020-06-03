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

        private void login_button_Click(object sender, EventArgs e)
        {
            //Создаем строки, которые заполняем вводом из текстбоксов
            String loginUser = login_textbox.Text;
            String passUser = password_textbox.Text;

            //Делаем подключение к базе данных
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //@loginUser и @loginPassword - заглушки, которые нужны для защиты от хацкеров, далее мы передаем этим заглушкам созданные строки
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login` = @loginUser AND `password` = @passUser", db.getConnection()); 
            command.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = passUser;

            //Выбрали нужную комманду и выполнили ее
            adapter.SelectCommand = command;
            //Все полученные данные поместили в созданную табличку
            adapter.Fill(table);

            //Если записи есть, то...
            if (table.Rows.Count > 0)
                MessageBox.Show("Вы вошли!");
            else
                MessageBox.Show("Не вошли :(");
            

        }
    }
}
