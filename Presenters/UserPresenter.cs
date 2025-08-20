using POS_V1._Repositories;
using POS_V1.Models;
using POS_V1.Services;
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
        private List<ComboModel> roleList;

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
            // do something behind the scenes
            _view.IsEdit = false;
            _view.Message = "Tangina ayaw gumana";
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
            UserModel userModel = new UserModel();
            userModel.Username = _view.Username;
            userModel.Password = _view.Password;
            userModel.First_name = _view.FirstName;
            userModel.Last_name = _view.LastName;
            userModel.Role = (UserRole)_view.Role;
            userModel.Email = _view.Email;
            userModel.Phone = _view.Phone;
            userModel.Is_active = _view.IsActive;
            userModel.Created_at = DateTime.Now;
            userModel.Updated_at= DateTime.Now;


            try
            {
                if (_view.IsEdit)
                {
                    // implement edit logic here
                }
                else
                {
                    new ModelDataValidation().Validate(userModel);
                    Console.WriteLine("===== UserModel Details =====");
                    Console.WriteLine($"Username   : {userModel.Username}");
                    Console.WriteLine($"Password   : {userModel.Password}");
                    Console.WriteLine($"First Name : {userModel.First_name}");
                    Console.WriteLine($"Last Name  : {userModel.Last_name}");
                    Console.WriteLine($"Role       : {userModel.Role}");
                    Console.WriteLine($"Email      : {userModel.Email}");
                    Console.WriteLine($"Phone      : {userModel.Phone}");
                    Console.WriteLine($"Is Active  : {userModel.Is_active}");
                    Console.WriteLine($"Created At : {userModel.Created_at}");
                    Console.WriteLine($"Updated At : {userModel.Updated_at}");
                    Console.WriteLine("==============================");

                    //_repository.Add(userModel);
                    _view.Message = "Successfully added new User.";
                }
                _view.MessageType = "Success";
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.Message = ex.Message;
                _view.MessageType = "Error";
                _view.IsSuccessful = false;
            }
           


        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
