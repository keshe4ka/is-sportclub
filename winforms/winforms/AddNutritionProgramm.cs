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
    public partial class AddNutritionProgramm : Form
    {
        private readonly Trainer Nutrition1;
        public AddNutritionProgramm(Trainer addNutritionProgramm)
        {
            InitializeComponent();
            AddNutritionLoad();
            showTrainerId();
            Nutrition1 = addNutritionProgramm;
        }

        //заполняем комбобокс
        private void AddNutritionLoad()
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
                    id_sportsman_comboBox.Items.Add(reader.GetString("id"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //запоминаем айди тренера
        private void showTrainerId()
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand getid = new MySqlCommand("SELECT trainer.id FROM user, trainer WHERE  trainer.User_id = '" + Program.appId + "'", db.getConnection());
            label5.Text = getid.ExecuteScalar().ToString();
            db.closeConnection();
        }

        //кнопка добавить
        private void addNutritionButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            if (wish_weight_textBox.Text == "")
            {
                MessageBox.Show("Вы не внесли значения!");
            }
            else
            {
                String query = "INSERT INTO nutrition_program(wish_weight , Trainer_id, Sportsman_id) " +
                "VALUES(@wish_weight, @Trainer_id, @Sportsman_id)";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.Add("@wish_weight", MySqlDbType.VarChar).Value = wish_weight_textBox.Text;
                command.Parameters.Add("@Trainer_id", MySqlDbType.VarChar).Value = label5.Text;
                command.Parameters.Add("@Sportsman_id", MySqlDbType.VarChar).Value = id_sportsman_comboBox.Text;
                MySqlDataReader reader = command.ExecuteReader();
                db.closeConnection();
                MessageBox.Show("Запись добавлена!");

                //очистка полей после ввода
                if (wish_weight_textBox.Text != " ")
                {
                    wish_weight_textBox.Text = " ";
                }

                //вызвали функцию обновления
                Nutrition1.RefreshGridNutrition();
            }
        }
    }
}
