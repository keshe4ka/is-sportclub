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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            //string connectString = "server = localhost; port = 3306; username = root; password = root; database = sportclub";
            //MySqlConnection myConenection = new MySqlConnection(connectString);
            //myConenection.Open();

            //Артем, убери весь позор сверху, у нас есть класс DB.cs, где все что ты делашеь сверху - две строчки ниже
            DB db = new DB();
            db.openConnection();

            String query = "SELECT * FROM `user`";
            MySqlCommand command = new MySqlCommand(query, db.getConnection()); //myConnection был заменен на db.getConnection()

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            db.closeConnection(); //myConenection.Close() был заменен на db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


        }
        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        //закрытие проги когда тык на крестик      
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
