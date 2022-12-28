using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLearn.forms
{
    public partial class CreateEvent : Form
    {
        public DBHandler dBHandler;

        public DBHandler summonDBHandler()
        {
            return dBHandler;
        }
        public CreateEvent()
        {
            dBHandler = new DBHandler();
            InitializeComponent();
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {

        }


        private void boardBtn_Click(object sender, EventArgs e)
        {
            KanbanForm form = new KanbanForm();
            form.Show();
        }

        private void addButton(object sender, EventArgs e)
        {
            DBHandler dBHandler = new DBHandler();
            DbConnection con = dBHandler.GetConnection();
            con.Open();
            
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            string eventName = eventBox.Text;
            string eventStartDate = eventDate.Value.ToString("dd.MM.yyyy"+"г.");
            int days = (int) (eventDateEnd.Value - eventDate.Value).TotalDays;
            int cityId = GetCityByName(cityBox.Text);
            dBHandler = new DBHandler();
            MySqlConnection con = dBHandler.GetConnection();
            con.Open();
            MySqlCommand command = new MySqlCommand("insert into events (`Событие`, `Дата`,`Дни`,`Город`) values('" + eventName + "','" + eventStartDate + "'," + days.ToString() + "," + cityId.ToString() + ");", con);
            command.Connection = con;
            Task task = command.ExecuteNonQueryAsync();
        }
        public int GetCityByName(string text)
        {
            MySqlConnection con = dBHandler.GetConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from cities where `Город`='" + text + "'", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                con.Close();
                return table.Rows[0].Field<int>(0);

            }
            else
            {
                cmd = new MySqlCommand("Insert into cities (`Город`) values('" + text + "')", con);
                Task task = cmd.ExecuteNonQueryAsync();
                task.Wait(2);
                cmd = new MySqlCommand("select max(`№`) from cities", con);
                table.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                con.Close();
                return table.Rows[0].Field<int>(0);
            }
        }
    }
    
}
