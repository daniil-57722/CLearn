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
    public partial class EventForm : Form
    {
        private DataTable events;

        public EventForm()
        {
            InitializeComponent();
        }

        public EventForm(DataTable events)
        {
            this.events = events;
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            String eventName = events.Rows[0].Field<String>(1);
            String eventdate = events.Rows[0].Field<String>(2);
            dateLabel.Text = eventdate;
            eventNameLabel.Text = eventName;
            DBHandler dbHandler = new DBHandler();
            MySqlConnection con = dbHandler.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            int eventCity = events.Rows[0].Field<int>(4);
            MySqlCommand command = new MySqlCommand("Select `Город` From cities Where  № = " + eventCity, con);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string city = table.Rows[0].Field<String>(0).ToString();
            cityLabel.Text = city;
            command = new MySqlCommand("Select `Победитель` From actives where `Наименование мероприятия` = '" + eventName+"'", con);
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            organizerLabel.Text = "unknown";
            descriptionLabel.Text = "Название: " + eventName + "\nГород: " + city + "\n" + "Дата: "+eventdate;
        }

        private void eventNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
