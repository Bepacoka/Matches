using System;
using System.Windows.Forms;

namespace LetovoProject
{
    public partial class GameForm : Form
    {
        private int n, k;
        private int[] dp = new int[200];
        private void Lock()
        {
            this.Enabled = false;
        }
        public GameForm(int n, int k)
        {
            InitializeComponent();

            this.n = n;
            this.k = k;

            Now_Label.Text = Convert.ToString("Сейчас " + n + " спичек");
            Take_Textbox.Text = Convert.ToString(k);
            for (int i = 1; i <= k; i++)
            {
                dp[i] = i;
            }

            for (int i = 0; i <= k; i++)
            {
                for (int j = 1; j < n / (k + 1); j++)
                {
                    if (i == 0)
                        dp[j * (k + 1)] = 1;
                    else
                        dp[j * (k + 1) + i] = i;
                }
            }

            for (int i = 0; i < n % (k + 1); i++)
            {
                if (i != 0)
                    dp[n / (k + 1) * (k + 1) + i] = i - 1;
                else
                    dp[n / (k + 1) * (k + 1) + i] = 1;
            }
        }
        private void Take_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Take_Textbox.Text.Length; i++)
            {
                if (char.IsDigit(Take_Textbox.Text[i]) == false)
                {
                    if (Take_Textbox.Text[i] != ',' && Take_Textbox.Text[i] != '.' && Take_Textbox.Text[i] != '-')
                    {
                        Lock();
                        GMB m = new GMB("Ошибка", "Вводите число!", this);
                        m.Show();
                        return;
                    }
                    else
                    {
                        Lock();
                        GMB m = new GMB("Ошибка", "Число должно быть натуральным!", this);
                        m.Show();
                        return;
                    }
                }
            }
            int l = Convert.ToInt32(Take_Textbox.Text);
            if (l == 0)
            {
                Lock();
                GMB m = new GMB("Ошибка", "Число должно быть натуральным!", this);
                m.Show();
                return;
            }
            if (l > k)
            {
                Lock();
                GMB m = new GMB("Ошибка", "Вы берёте слишком много!", this);
                m.Show();
                return;
            }
            else
            {
                n -= l;
                if (n == 0)
                {
                    SettingsForm f = new SettingsForm();
                    f.Show();
                    this.Hide();
                    GMB m = new GMB("Победа!", "Вы победили!", this);
                    m.Show();
                    return;
                }
                Now_Label.Text = Convert.ToString("Сейчас " + n + " спичек");
                Lock();
                GMB b = new GMB("Внимание", "Бот взял " + dp[n] + " спичек!", this);
                b.Show();
                n -= dp[n];
                if (n == 0)
                {
                    b.Close();
                    SettingsForm f = new SettingsForm();
                    f.Show();
                    this.Hide();
                    SMB m = new SMB("Проигрыш!", "Вы проиграли!", f);
                    m.Show();
                    return;
                }
                Now_Label.Text = Convert.ToString("Сейчас " + n + " спичек");
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Program.Play();
            Application.Exit();
        }
    }
}
