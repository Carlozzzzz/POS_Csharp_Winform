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
using System.Windows.Forms;

namespace POS_V1.Presenters
{
    public class LoginPresenter
    {
        private ILoginView _loginView;
        private ILoginRepository _logRepository;

        public LoginPresenter(ILoginView loginView, ILoginRepository logRepository)
        {
            this._loginView = loginView;
            this._logRepository = logRepository;
            // subscribe to events
            this._loginView.LoginEvent += OnLogin;
            this._loginView.CancelEvent += CancelLogin;
        }

        private void CancelLogin(object sender, EventArgs e)
        {
            _loginView.Close();
        }

        private void OnLogin(object sender, EventArgs e)
        {
            try
            {
                LoginModel model = new LoginModel();
                model.Username = _loginView.Username;
                model.Password = _loginView.Password;

                new ModelDataValidation().Validate(model);
                model = _logRepository.ValidateUser(model.Username, model.Password);
                _loginView.IsSuccessful = true;
                _loginView.Message = "Logged in Success.";
                _loginView.DialogResult = DialogResult.OK;

                // Set Session
                Session.SetSession(model);


                // Close the login view
                _loginView.Close();

            }
            catch (Exception ex) 
            {
                _loginView.Message = ex.Message;
                _loginView.IsSuccessful = false;
            }
        }
    }
}
