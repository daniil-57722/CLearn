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
    public partial class OrganizatorForm : Form
    {
        private string[] fullname;

        public OrganizatorForm()
        {
            InitializeComponent();
        }

        public OrganizatorForm(string[] fullname)
        {
            this.fullname = fullname;
            InitializeComponent();
        }

        private void OrganizatorForm_Load(object sender, EventArgs e)
        {
            string intro = "Добр";
            if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 11)
            {
                intro += "ое утро";
            }
            else if (DateTime.Now.Hour >= 11 && DateTime.Now.Hour < 18)
            {
                intro += "ый день";
            }
            else
            {
                intro += "ый вечер";
            }
            intro += ", " + fullname[0] + " " + fullname[1] + " " + fullname[2];
            introLabel.Text = intro;
            avatar.Image = Image.FromFile("D:\\С#_proj\\CLearn\\CLearn\\images\\organizators\\" + fullname[3]);
        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void OrganizatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm(fullname);
            form.Show();
        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {
            CreateEvent form = new CreateEvent();
            form.Show();
        }

        private void juriBtn_Click(object sender, EventArgs e)
        {
            JuriForm form = new JuriForm();
            form.Show();
        }
    }
}
