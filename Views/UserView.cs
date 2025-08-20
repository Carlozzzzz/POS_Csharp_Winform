using POS_V1.Models;
using POS_V1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_V1.Views
{
    public partial class UserView : Form, IUserView
    {
        private bool isDeleted;
        private DateTime createdAt;
        private DateTime updatedAt;
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        private string messageType;

        public UserView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tcUser.TabPages.Remove(tpUserManage);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbSearch.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty);
                };

            // Add
            btnAdd.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ShowUserManage();
            };

            // Save
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ShowUserList();
                }

                MessageBox.Show(Message, MessageType, MessageBoxButtons.OK, CustomHelper.GetMessageBoxIcon(MessageType));
            };
        }

        private void ShowUserManage()
        {
            tcUser.TabPages.Remove(tpUserList);
            tcUser.TabPages.Add(tpUserManage);
        }
        private void ShowUserList()
        {
            tcUser.TabPages.Remove(tpUserManage);
            tcUser.TabPages.Add(tpUserList);
        }

        #region Properties
        public string UserId { 
            get => tbUserId.Text; 
            set => tbUserId.Text = value; 
        }
        public string Username { 
            get => tbUsername.Text; 
            set => tbUsername.Text = value; 
        }
        public string Password { 
            get => tbPassword.Text; 
            set => tbPassword.Text = value; 
        }
        public string PasswordRepeat { 
            get => tbPasswordRepeat.Text; 
            set => tbPasswordRepeat.Text = value; 
        }
        public string FirstName { 
            get => tbFirstName.Text; 
            set => tbFirstName.Text = value; 
        }
        public string LastName { 
            get => tbLastName.Text; 
            set => tbLastName.Text = value; 
        }
        public int Role { 
            get => (int)cbUserRole.SelectedValue;
            set => cbUserRole.SelectedValue = (int)value; 
        }
        public string Email { 
            get => tbEmail.Text; 
            set => tbEmail.Text = value; 
        }
        public string Phone
        {
            get => tbPhone.Text;
            set => tbPhone.Text = value;
        }
        public bool IsActive {
            get => cbStatus.SelectedItem?.ToString().ToLower() == "active";
            set => cbStatus.SelectedItem = value ? "active" : "inactive";
        }
        public bool IsDeleted { 
            get => isDeleted; 
            set => isDeleted = value; 
        }
        public DateTime CreatedAt {
            get => createdAt;
            set => createdAt = value;
        }
        public DateTime UpdatedAt { 
            get => updatedAt; 
            set => updatedAt = value; 
        }
        public bool IsEdit { 
            get => isEdit; 
            set => isEdit = value; 
        }
        public bool IsSuccessful { 
            get => isSuccessful; 
            set => isSuccessful = value; 
        }
        public string Message { 
            get => message; 
            set => message = value; 
        }
        public string MessageType
        {
            get => messageType = string.IsNullOrEmpty(messageType) ? "Information" : messageType;
            set => messageType = string.IsNullOrEmpty(value) ? "Information" : value;
        }
        public string SearchValue
        {
            get => tbSearch.Text;
            set => tbSearch.Text = value;
        }
        #endregion

        #region Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler SoftDeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        #endregion

        public void SetUserListBindingSource(BindingSource userList)
        {
            userListGridView.DataSource = userList;
            userListGridView.Columns["Id"].Visible = false;
            userListGridView.Columns["Is_deleted"].Visible = false;

        }

        public void PopulateRole(List<ComboModel> roleList)
        {
            cbUserRole.DataSource = roleList;
            cbUserRole.ValueMember = "Value";
            cbUserRole.DisplayMember = "Name";
        }

        #region Display Behavior
        // Singleton pattern (Open a single form instance)
        private static UserView instance;

        public static UserView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UserView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
        #endregion

    }
}
