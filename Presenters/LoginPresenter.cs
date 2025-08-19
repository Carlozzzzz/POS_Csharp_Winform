using POS_V1._Repositories;
using POS_V1.Models;
using POS_V1.Services;
using POS_V1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1.Presenters
{
    public class LoginPresenter
    {
        private ILoginView _loginView;
        private ILoginRepository _logRepository;
        private readonly string connectionString;

        public LoginPresenter(ILoginView loginView, ILoginRepository logRepository)
        {
            _loginView = loginView;
            _logRepository = logRepository;

            _loginView.LoginEvent += OnLogin;
        }

        private void OnLogin(object sender, EventArgs e)
        {
            try
            {
                LoginModel model = new LoginModel();
                model.Username = _loginView.Username;
                model.Password = _loginView.Password;

                new ModelDataValidation().Validate(model);
                bool result = _logRepository.ValidateUser(model.Username, model.Password);

                _loginView.Message = "Success";
                _loginView.ShowMessage();


                ShowDashboardView();
            }
            catch (Exception ex) 
            {
                _loginView.Message = ex.Message;
                _loginView.ShowErroredMessage();
            }

           
        }

        private void ShowDashboardView()
        {
            IMainView _mainView = new MainView();
            new MainPresenter(_mainView, connectionString);
        }
    }
}
