using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetovoProject
{
    public partial class GMB : Form
    {
        GameForm f = new GameForm(2, 2);
        public GMB(string h, string text, GameForm f)
        {
            InitializeComponent();
            MessageBoxH.Text = h;
            MessageBoxText.Text = text;
            this.f = f;
        }

        private void Unlock()
        {
            f.Enabled = true;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Program.Play();
            Unlock();
            this.Close();
        }
    }
}
