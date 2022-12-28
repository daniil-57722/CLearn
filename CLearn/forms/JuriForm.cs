using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLearn.forms
{
    public partial class JuriForm : Form
    {
        public JuriForm()
        {
            InitializeComponent();
        }

        private void JuriForm_Load(object sender, EventArgs e)
        {
            DBHandler dBhandler = new DBHandler();
            MySqlConnection con = dBhandler.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand com = new MySqlCommand("SELECT `Фмамилия` from moderators UNION SELECT `Фамилия` FROM juri", con);
            con.Open();
            DataTable events = new DataTable();
            adapter.SelectCommand = com;
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                personBox.Items.Add(reader[0]);
            }
            con.Close();
            com = new MySqlCommand("SELECT `Событие` FROM events", con);
            DBHandler dbhandler = new DBHandler();
            con.Open();
            events.Clear();
            adapter.SelectCommand = com;
            reader = com.ExecuteReader();
            while (reader.Read())
            { eventBox2.Items.Add(reader[0]); }
            reader.Close();
            com = new MySqlCommand("SELECT №, `Фмамилия`,`Имя`,`Отчество` FROM moderators UNION SELECT №, `Фамилия`,`Имя`,`Отчество` FROM juri", con);
            DataTable all = new DataTable();
            adapter.SelectCommand = com;
            adapter.Fill(all);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = all;
            personList.DataSource = dataSource;
            amountLbl.Text = all.Rows.Count.ToString();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            DBHandler dB = new DBHandler();
            MySqlConnection con = dB.GetConnection();
            string person = personBox.Text;
            string enter_event = eventBox2.Text;
            MySqlCommand command = new MySqlCommand("SELECT №, `Фмамилия`,`Имя`,`Отчество` FROM moderators where `Фмамилия` = '"+person+"' UNION SELECT №, `Фамилия`,`Имя`,`Отчество` FROM juri where `Фамилия` = '"+person+"'", con);
            DataTable users = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(users);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = users;
            personList.DataSource = dataSource;
            amountLbl.Text = users.Rows.Count.ToString();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
        }
    }
}
