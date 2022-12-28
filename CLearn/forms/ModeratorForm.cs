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
    public partial class ModeratorForm : Form
    {
        private string[] fullname;

        public ModeratorForm()
        {
            InitializeComponent();
        }
        public ModeratorForm(string[] fullname)
        {
            this.fullname = fullname;
            InitializeComponent();
        }

        private void ModeratorForm_Load(object sender, EventArgs e)
        {
            string intro = "Добр";
            if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 11)
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
        }

        private void ModeratorFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
