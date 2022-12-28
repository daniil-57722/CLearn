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
    public partial class ProfileForm : Form
    {
        private string[] fullname;

        public ProfileForm()
        {
            InitializeComponent();
        }

        public ProfileForm(string[] fullname)
        {
            this.fullname = fullname;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            DataTable user = new DataTable();
            fullnameLbl.Text = fullname[0] + " " + fullname[1] + " " + fullname[3];
            pictureBox1.Image = Image.FromFile("D:\\С#_proj\\CLearn\\CLearn\\images\\organizators\\" + fullname[3]);
            DBHandler dBhandler = new DBHandler();
            MySqlConnection con = dBhandler.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand com = new MySqlCommand("Select * From organizators where `Фамилия` = '" + fullname[0] + "' and `Имя` = '" + fullname[1] + "' and `Отчество` = '" + fullname[2] +"'", con);
            adapter.SelectCommand = com;
            adapter.Fill(user);
            genderLbl.Text = user.Rows[0].Field<String>(10);
            DateLbl.Text = user.Rows[0].Field<String>(5);
            numberLabel.Text = user.Rows[0].Field<int>(0).ToString();
            phoneLbl.Text = user.Rows[0].Field<String>(7);
            mailLbl.Text = user.Rows[0].Field<String>(4);
            passwordLbl.Text = user.Rows[0].Field<String>(8);
            com = new MySqlCommand("Select `Название страны` from countries where № = " + user.Rows[0].Field<int>(6), con);
            adapter.SelectCommand = com;
            user.Clear();
            adapter.Fill(user);
            MessageBox.Show(user.Rows[0].Field<String>(0));
            countryLbl.Text= user.Rows[0].Field<String>(0);



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
