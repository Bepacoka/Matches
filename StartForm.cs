using System;
using System.Windows.Forms;

namespace LetovoProject
{
    public partial class StartForm : Form
    {
                                                                                                                  //отображение всего
        public StartForm()
        {
            InitializeComponent();
        }
                                                                                                                  //запуск настроек
        private void StartButton_Click(object sender, EventArgs e)
        {
                                                                                                                  //просто майнкрафт
            Program.Play();
                                                                                                                  //запуск
            SettingsForm f = new SettingsForm();
            f.Show();
            this.Hide();
        }
                                                                                                                  //выход
        private void ExitButton_Click(object sender, EventArgs e)
        {
                                                                                                                  //просто майнкрафт
            Program.Play();
                                                                                                                  //выход
            Application.Exit();
        }
    }
}
