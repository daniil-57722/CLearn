using MySql.Data.MySqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;


namespace CLearn.forms
{
    public partial class StartForm : Form
    {
        DBHandler dBHandler = new DBHandler();

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            sortBox.Items.Add("Дате");
            sortBox.Items.Add("Алфавиту");
            this.eventsList.DefaultCellStyle.Font = new Font("Comic Sans MS", 10);
            MySqlConnection connection = dBHandler.GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT `Событие`, `Дата` FROM events", connection);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable events = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(events);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = events;
            eventsList.DataSource = dataSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection connection = dBHandler.GetConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM events WHERE `Событие` = @e",connection);

            command.Parameters.Add("@e", MySqlDbType.VarChar).Value = eventsList[0, e.RowIndex].Value.ToString();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable events = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(events);

            EventForm eventForm = new EventForm(events);
            eventForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlcmd;
            if (sortBox.SelectedIndex == 1)
            {
                sqlcmd = "SELECT `Событие`, `Дата` FROM events order BY `Дата`";
            }
            else
            {
                sqlcmd = "SELECT `Событие`, `Дата` FROM events ORDER BY `Событие` ASC";
            }
            MySqlConnection connection = dBHandler.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sqlcmd, connection);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable events = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(events);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = events;
            eventsList.DataSource = dataSource;
        }
    }
}
