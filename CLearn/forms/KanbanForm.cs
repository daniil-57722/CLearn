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

namespace CLearn.forms
{
    public partial class KanbanForm : Form
    {
        public KanbanForm()
        {
            InitializeComponent();
        }

        private void KanbanForm_Load(object sender, EventArgs e)
        {
            DBHandler dBhandler = new DBHandler();
            MySqlConnection con = dBhandler.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand com = new MySqlCommand("SELECT `Событие` from events", con);
            con.Open();
            DataTable events = new DataTable();
            adapter.SelectCommand = com;
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                eventBox.Items.Add(reader[0]);
            }
        }
    }
}
