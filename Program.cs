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

            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            while (true)
            {
                //LoginView loginView = new LoginView();
                //ILoginRepository loginRepository = new LoginRepository(connectionString);
                //new LoginPresenter(loginView, loginRepository);

                //if (loginView.ShowDialog() == DialogResult.OK)
                //{
                    MainView mainView = new MainView();
                    new MainPresenter(mainView, connectionString);
                    Application.Run(mainView);

                    if (!mainView.IsLoggedout)
                        break; // user closed app normally → exit loop
                //}
                //else
                //{
                //    break; // login canceled → exit app
                //}
            }
        }
    }
}
