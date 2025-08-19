using POS_V1._Repositories;
using POS_V1.Models;
using POS_V1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_V1.Presenters
{
    public class UserPresenter
    {
        private IUserView _view;
        private IUserRepository _repository;
        private BindingSource usersBindingSource;
        private IEnumerable<UserModel> userList;

        public UserPresenter(IUserView view, IUserRepository repository)
        {
            this.usersBindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;

            // Subscribe to events
            this._view.SearchEvent += SearchUser;
            this._view.AddNewEvent += AddNewUser;
            this._view.EditEvent += LoadSelectedUserToEdit;
            this._view.SoftDeleteEvent += SoftDeletePet;
            this._view.SaveEvent += SaveUser;
            this._view.CancelEvent += CancelAction;

            // Set user binded source
            this._view.SetUserListBindingSource(usersBindingSource);
            LoadAllUserList();
            this._view.Show();

        }

        private void LoadAllUserList()
        {
            userList = _repository.GetAll();
            usersBindingSource.DataSource = userList;
        }

        private void SearchUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedUserToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SoftDeletePet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
