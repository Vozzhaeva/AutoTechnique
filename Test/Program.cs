using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var fReg = new Autorisation();
            DialogResult res;
            do
            {
                res = fReg.ShowDialog();
                if (res == DialogResult.Retry)
                {
                    fReg.setTextoxRed();
                }
            }
            while (res != DialogResult.OK && res != DialogResult.Cancel);
            if (res == DialogResult.Cancel) return;
            if (fReg.userType == "1")    //менеджержер
            {
                Manager uForm = new Manager();
                uForm.ShowDialog();
            }
            if (fReg.userType == "2")     //администратор
            {
               (new Administrator()).ShowDialog();  
            }
        }
    }

    static class Data
    {
        public static string value { get; set; }
    }
}
