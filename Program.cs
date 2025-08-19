using POS_V1._Repositories;
using POS_V1.Presenters;
using POS_V1.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_V1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // set the connection here
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ILoginView loginView = new LoginView();
            ILoginRepository loginRepository = new LoginRepository(connectionString);
            new LoginPresenter(loginView, loginRepository);
            Application.Run((Form)loginView);
        }
    }
}
