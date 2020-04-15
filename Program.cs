using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_A1_Supermecado.Controller;
using Trabalho_A1_Supermecado.Forms;

namespace Trabalho_A1_Supermecado
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            if(login.ShowDialog() == DialogResult.OK && Sessao.active()){
                Application.Run(new Home());
            }
        }
    }
}
