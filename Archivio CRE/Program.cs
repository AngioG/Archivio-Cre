using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivio_CRE
{
    static class Program
    {
        private static GlobalConfiguration globalConfig = null;
        private static List<Thread> activeThreads = new List<Thread>();

        public static GlobalConfiguration GlobalConfig { get => globalConfig; set => globalConfig = value; }
        public static List<Thread> ActiveThreads { get => activeThreads; }
        public static int timeLeft { get; set; }
        public static bool Ripeti { get; set; }

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {

            GlobalConfig = GlobalConfiguration.ReadJson();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (GlobalConfig.EleLogin.Count == 0) GlobalConfig.EleLogin.Add(new Login("admin", "", true, true, true));

            do
            {
                Ripeti = false;
                Application.Run(new frm_vis());
                if (!frm_login.Aborted && GlobalConfig.CanInsert && !GlobalConfig.Open)
                {
                    timeLeft = 60000;
                    GlobalConfig.Blocca();
                    Application.Run(new frm_main());
                }
            } while (Ripeti);

        }
    }
}
