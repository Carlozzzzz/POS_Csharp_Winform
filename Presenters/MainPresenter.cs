using POS_V1._Repositories;
using POS_V1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS_V1.Presenters
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private readonly string connectionString;

        public MainPresenter(IMainView mainView, string connectionString)
        {
            this._mainView = mainView;
            this.connectionString = connectionString;


            // Subscribe to the event here
            this._mainView.LogoutEvent += Logout;
            this._mainView.ShowDashboardView += ShowDashboardsView;
            this._mainView.ShowUserView += ShowUsersView;
            this._mainView.ShowProductView += ShowProductsView;
            this._mainView.Show();
        }

        private void ShowDashboardsView(object sender, EventArgs e)
        {
            _mainView.Message = "Puputukan ka na ni kumare ng Dashboard";
        }

        private void ShowUsersView(object sender, EventArgs e)
        {
            _mainView.Message = "Puputukan ko na ni kumare ng Users";
            IUserView userView = UserView.GetInstance((Form)_mainView);
            IUserRepository userRepository = new UserRepository(connectionString);
            new UserPresenter(userView, userRepository);
        }


        private void ShowProductsView(object sender, EventArgs e)
        {
            _mainView.Message = "Puputukan ka na ni kumare ng Products";
        }

        private void Logout(object sender, EventArgs e)
        {
            _mainView.IsLoggedout = true;
            _mainView.Close();
        }

        // Create the operations for your events here
    }
}
