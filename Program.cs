using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Template_SM22_Csharp.Views;

namespace Project_Template_SM22_Csharp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSach());
        }
        //Scaffold-DbContext 'Data Source=DESKTOP-D08A7VN;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Persist Security Info=True;User ID=duytdph20598;Password=123456' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
    }
}