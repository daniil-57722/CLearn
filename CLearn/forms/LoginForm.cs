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
using Timer = System.Windows.Forms.Timer;

namespace CLearn.forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        String text ="";


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int k = 0;

        private void findAll()
        {
            string[] fullname = new string[4];
            Console.WriteLine(k);
            string[] tables = { "participants", "moderators", "organizators", "juri" };
            DataTable users = new DataTable();
            foreach (string i in tables)
            {
                DBHandler dbhandler = new DBHandler();
                MySqlConnection connection = dbhandler.GetConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + i + " WHERE `№` = @n AND `пароль` = @p", connection);
                cmd.Parameters.Add("@n", MySqlDbType.Int32).Value = numberBox.Text;
                cmd.Parameters.Add("@p", MySqlDbType.VarChar).Value = passwordBox.Text;
                adapter.SelectCommand = cmd;
                adapter.Fill(users);
                if (users.Rows.Count > 0)
                {
                    MessageBox.Show(cmd.CommandText.ToString());
                    if (i == "organizators")
                    {
                        fullname[0] = users.Rows[0].Field<String>(1);
                        fullname[1] = users.Rows[0].Field<String>(2);
                        fullname[2] = users.Rows[0].Field<String>(3);
                        fullname[3] = users.Rows[0].Field<String>(9);
                        OrganizatorForm form = new OrganizatorForm(fullname);
                        this.Hide();
                        form.Show();
                    }
                    if (i == "moderators")
                    {
                        fullname[0] = users.Rows[0].Field<String>(1);
                        fullname[1] = users.Rows[0].Field<String>(2);
                        fullname[2] = users.Rows[0].Field<String>(3);
                        ModeratorForm form = new ModeratorForm(fullname);
                        this.Hide();
                        form.Show();
                    }
                }
                else
                {
                    k++;
                    if (k == 3)
                    {
                        Thread thread = new Thread(DisableWindow);
                        thread.Start();
                    }
                }
                users.Clear();
            }
        }
        private void DisableWindow()
        {
            k = 0;
            loginBtn.Enabled = false;
            Thread.Sleep(10000);
            loginBtn.Enabled = true;
        }

        /// <summary>
        /// login via DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void loginBtn_Click(object sender, EventArgs e)
        {
            findAll();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseLoginForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
