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
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft;

namespace winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
            LoadSportsData();
        }

        //подключаемся к таблице пользователи
        private void LoadData()
        {
            {
                DB db = new DB();
                db.openConnection();
                String query = "SELECT id, second_name AS `Фамилия`, name AS `Имя`, patronymic AS `Отчество`, login AS `Логин`, password AS `Пароль`, Role AS `Роль` FROM user";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
                DataSet data = new DataSet();
                adapter.Fill(data);
                BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
                dataGridView1.DataSource = bs;
                db.closeConnection();
            }

        }

        //прогружаем данные видов спорта
        private void LoadSportsData()
        {
            DB db = new DB();
            db.openConnection();
            String query = "SELECT id, name AS `Название`, world_record AS `Мировой рекорд`, date_of_record AS `Дата рекорда` FROM kind_of_sport";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            DataSet data = new DataSet();
            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            sports_dataGridView.DataSource = bs;
            db.closeConnection();
        }

        //форма для добавление пользователей
        private void addButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(this);
            addUser.Show();

        }

        //удаление пользователей
        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //кидаем проверочку
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удалить данные", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DB db = new DB();
                    db.openConnection();
                    int rowIdToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    MySqlCommand command = new MySqlCommand("DELETE FROM user WHERE id = '" + rowIdToDelete + "'", db.getConnection());
                    try
                    {
                        db.openConnection();
                        MySqlDataReader dataReader = command.ExecuteReader();
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        db.closeConnection();
                        RefreshGrid();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }


        //закрытие проги когда тык на крестик      
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void RefreshGrid()
        {
            LoadData();
        }
        public void RefreshGridSport()
        {
            LoadSportsData();
        }

        //поиск по фамилии пользовтаеля
        private void search_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].FormattedValue.ToString().Contains(search_secondname_textBox.Text))
                {
                    dataGridView1.Rows[i].Selected = true;
                }
                else
                {
                    dataGridView1.Rows[i].Selected = false;
                }
            }
        }

        //форма добавления вида спорта
        private void AddSportButton_Click(object sender, EventArgs e)
        {
            AddSport addSport = new AddSport(this);
            addSport.Show();
        }

        //удаление вида спорта
        private void DeliteSportButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sports_dataGridView.SelectedRows)
            {
                //кидаем проверочку
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удалить данные", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DB db = new DB();
                    db.openConnection();
                    int rowIdToDelete = Convert.ToInt32(sports_dataGridView.SelectedRows[0].Cells[0].Value);
                    MySqlCommand command = new MySqlCommand("DELETE FROM kind_of_sport WHERE id = '" + rowIdToDelete + "'", db.getConnection());
                    try
                    {
                        db.openConnection();
                        MySqlDataReader dataReader = command.ExecuteReader();
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        db.closeConnection();
                        RefreshGridSport();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        //выгрузка данных
        private void export_button_Click(object sender, EventArgs e)
        {
            LoadSportsData();
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void copyAlltoClipboard()
        {
            sports_dataGridView.SelectAll();
            DataObject dataObj = sports_dataGridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
    }
}
