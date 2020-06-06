using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class Referee : Form
    {
        public Referee()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
           
            DB db = new DB();
            db.openConnection();

            String query = "SELECT * FROM `competition`";
            MySqlCommand command = new MySqlCommand(query, db.getConnection()); 

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }

            reader.Close();

            db.closeConnection(); 

            foreach (string[] s in data)
                competitions_dataGridView.Rows.Add(s);


        }

        private void Referee_Load(object sender, EventArgs e)
        {

        }

        private void Referee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
