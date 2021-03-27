using System;
using System.Media;
using System.Windows.Forms;

namespace LetovoProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
        public static void Play()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream = assembly.GetManifestResourceStream(@"LetovoProject.Files.click.wav");
            SoundPlayer player = new SoundPlayer(resourceStream);
            player.PlaySync();
        }
    }
}
