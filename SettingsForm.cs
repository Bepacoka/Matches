using System;
using System.Windows.Forms;

namespace LetovoProject
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void Lock()
        {
            this.Enabled = false;
        }
        public void Unlock()
        {
            this.Enabled = true;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //просто майнкрафт
            Program.Play();
            //выход
            Application.Exit();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            Program.Play();
            string n_text = N_Textbox.Text;
            string k_text = K_Textbox.Text;
            for (int i = 0; i < n_text.Length; i++)
            {
                if (char.IsDigit(n_text[i]) == false)
                {
                    if (n_text[i] != ',' && n_text[i] != '.' && n_text[i] != '-')
                    {
                        Lock();
                        SMB m = new SMB("Ошибка", "Вводите число!", this);
                        m.Show();
                        return;
                    }
                    else
                    {
                        Lock();
                        SMB m = new SMB("Ошибка", "Число должно быть натуральным!", this);
                        m.Show();
                        return;
                    }
                }
            }
            for (int i = 0; i < k_text.Length; i++)
            {
                if (char.IsDigit(k_text[i]) == false)
                {
                    if (k_text[i] != ',' && k_text[i] != '.' && k_text[i] != '-')
                    {
                        Lock();
                        SMB m = new SMB("Ошибка", "Вводите число!", this);
                        m.Show();
                        return;
                    }
                    else
                    {
                        Lock();
                        SMB m = new SMB("Ошибка", "Число должно быть натуральным!", this);
                        m.Show();
                        return;
                    }
                }
            }
            if (Convert.ToInt32(n_text) == 0)
            {
                SMB m = new SMB("Ошибка", "Число должно быть натуральным!", this);
                m.Show();
                return;
            }
            if (Convert.ToInt32(k_text) == 0)
            {
                SMB m = new SMB("Ошибка", "Число должно быть натуральным!", this);
                m.Show();
                return;
            }
            if (Convert.ToInt32(n_text) > 200)
            {
                SMB m = new SMB("Ошибка", "Слишком большое число (> 200)!", this);
                m.Show();
                return;
            }
            if (Convert.ToInt32(n_text) < 10)
            {
                SMB m = new SMB("Ошибка", "Слишком маленькое число (< 10)!", this);
                m.Show();
                return;
            }
            if (Convert.ToInt32(k_text) >= Convert.ToInt32(n_text) / 2)
            {
                SMB m = new SMB("Ошибка", "Кол-во спичек которые можно брать не должно превышать половины всех спичек!", this);
                m.Show();
                return;
            }
            GameForm f = new GameForm(Convert.ToInt32(n_text), Convert.ToInt32(k_text));
            f.Show();
            this.Close();
        }
    }
}
