using POS_V1._Repositories;
using POS_V1.Models;
using POS_V1.Services;
using POS_V1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        private List<ComboModel> roleList;
        private List<ComboModel> statusList;

        public UserPresenter(IUserView view, IUserRepository repository)
        {
            this.usersBindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;

            // Subscribe to events
            this._view.SearchEvent += SearchUser;
            this._view.AddNewEvent += AddNewUser;
            this._view.EditEvent += EditUser;
            this._view.SoftDeleteEvent += SoftDeleteUser;
            this._view.SaveEvent += SaveUser;
            this._view.RefreshEvent += RefreshUserList;
            this._view.CancelEvent += CancelAction;

            // Set user binded source
            LoadAllUserList();
            this._view.SetUserListBindingSource(usersBindingSource);
            this.roleList = LoadAllRoleList();
            this._view.PopulateRole(roleList);
            this._view.Show();
        }

       
        private void LoadAllUserList()
        {
            userList = _repository.GetAll();
            usersBindingSource.DataSource = userList;

        }

        private List<ComboModel> LoadAllRoleList()
        {
            var roles = new List<ComboModel>();

            roles.Add(new ComboModel() { Name = "-Select Role-", Value = 0 });

            foreach (var role in Enum.GetValues(typeof(UserRole)))
            {
                int value = (int)role;
                roles.Add(new ComboModel() { Name = role.ToString(), Value = value });
            }
            return roles;
        }

        private void SearchUser(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this._view.SearchValue);
            if (emptyValue) userList = _repository.GetAll();
            else userList = _repository.GetByValue(this._view.SearchValue);

            usersBindingSource.DataSource = userList;
        }

        private void AddNewUser(object sender, EventArgs e)
        {
            // Check whether inserting or updated
            _view.IsEdit = false;
        }

        private void EditUser(object sender, EventArgs e)
        {
            // Display the User Manage tab
            // Quick fix to show the User Manage tab 
            // Avoid not showing the tab when clicking the Edit button
            _view.ShowUserManage();

            var user = (UserModel)usersBindingSource.Current;
            _view.UserId = user.Id.ToString();
            _view.Username = user.Username;
            _view.Password = user.Password;
            _view.PasswordRepeat = user.Password;
            _view.FirstName = user.First_name;
            _view.LastName = user.Last_name;
            _view.Role = user.Role;
            _view.Email = user.Email;
            _view.Phone = user.Phone;
            _view.Status = user.Status;

            _view.IsEdit = true;
        }

        private void SoftDeleteUser(object sender, EventArgs e)
        {
            // Reload the List
            try
            {
                var user = (UserModel)usersBindingSource.Current;
                _repository.SoftDelete(user.Id);
                _view.Message = "User successfully deleted.";
                _view.MessageType = "Success";

                // Refresh User List
                LoadAllUserList();

            }
            catch (Exception ex)
            {
                _view.Message = "Error deleting the user." + ex.Message;
                _view.MessageType = "Error";
            }
        }

        private void SaveUser(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();
            userModel.Username = _view.Username;
            userModel.Password = _view.Password;
            userModel.First_name = _view.FirstName;
            userModel.Last_name = _view.LastName;
            userModel.Role = (UserRole)_view.Role;
            userModel.Email = _view.Email;
            userModel.Phone = _view.Phone;
            userModel.Status = _view.Status;
            userModel.Updated_at= DateTime.Now;

            bool isCorrectPassword = _view.PasswordRepeat == userModel.Password;

            try
            {
                // Domain layer validation, throw exception when one criteria fail
                new ModelDataValidation().Validate(userModel);
                if (isCorrectPassword)
                {
                    if (_view.IsEdit)
                    {
                        userModel.Id = Convert.ToInt32(_view.UserId);
                        _view.Message = "User updated successfully.";
                        _repository.Edit(userModel);
                    }
                    else
                    {
                        userModel.Created_at = DateTime.Now;
                        _view.Message = "User added successfully.";
                        _repository.Add(userModel);
                    }

                    _view.MessageType = "Success";
                    _view.IsSuccessful = true;
                    CleanviewFields();

                    // Reload the List
                    LoadAllUserList();
                }
                else
                {
                    _view.MessageType = "Error";
                    _view.Message = "Password not match";
                }
            }
            catch (Exception ex)
            {
                _view.Message = ex.Message;
                _view.MessageType = "Error";
                _view.IsSuccessful = false;
            }
        }

        private void RefreshUserList(object sender, EventArgs e)
        {
            LoadAllUserList();
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void CleanviewFields()
        {
            _view.UserId = "0";
            _view.FirstName = "";
            _view.LastName = "";
            _view.Username = "";
            _view.Password = "";
            _view.PasswordRepeat = "";
            _view.Email = "";
            _view.Phone = "";
            _view.Role = 0;
            _view.Status = "";
        }
    }
}
