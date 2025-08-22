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

            // Event Invoker
            AssociateAndRaiseViewEvents();
            tcUser.TabPages.Remove(tpUserManage);
        }

        #region Private Functions
        private void AssociateAndRaiseViewEvents()
        {
            // Search and Filter
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbSearch.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty);
                };

            btnApplyFilter.Click += delegate { 
                FilterEvent?.Invoke(this, EventArgs.Empty);

                // Debugging the inputs
                if (IsSuccessful == false)
                {
                    MessageBox.Show(Message);
                }
            };

            // Add
            btnAdd.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ShowUserManage();
            };

            // Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
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

            //Softdelete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SoftDeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message, MessageType, MessageBoxButtons.OK, CustomHelper.GetMessageBoxIcon(MessageType));
                }
            };

            //Refresh
            btnRefresh.Click += delegate { RefreshEvent?.Invoke(this, EventArgs.Empty); };

            btnCancel.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ShowUserList();
            };
        }

        private void ShowUserList()
        {
            tcUser.TabPages.Remove(tpUserManage);
            tcUser.TabPages.Add(tpUserList);
        }
        #endregion

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
        public UserRole Role {
            get => (UserRole)(cbUserRole.SelectedValue ?? 0);
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
        public string Status{
            get => cbStatus.SelectedIndex.ToString();
            set {
                Console.WriteLine(value);
                if (value == "True")
                {
                    cbStatus.SelectedIndex = 1;
                }
                else if (value == "False")
                {
                    cbStatus.SelectedIndex = 2;
                }
                else
                {
                    cbStatus.SelectedIndex = 0;
                }
            }
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

        // Filter Properties
        public string SearchValue
        {
            get => tbSearch.Text;
            set => tbSearch.Text = value;
        }
        public int RoleFilter
        {
            get => (int)cbRoleFilter.SelectedValue; 
            set => cbRoleFilter.SelectedValue = value; 
        }
        public string StatusFilter
        {
            get => cbStatusFilter.SelectedIndex.ToString();
            set
            {
                if (value == "True")
                {
                    cbStatusFilter.SelectedIndex = 1;
                }
                else if (value == "False")
                {
                    cbStatusFilter.SelectedIndex = 2;
                }
                else
                {
                    cbStatusFilter.SelectedIndex = 0;
                }
            }
        }
        public DateTime FromDateFilter
        {
            get => dtpStartDateFilter.Value;
            set => dtpStartDateFilter.Value = value;
        }
        public DateTime ToDateFilter
        {
            get => dtpEndDateFilter.Value;
            set => dtpEndDateFilter.Value = value;
        }
        #endregion

        #region Events
        public event EventHandler SearchEvent;
        public event EventHandler FilterEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler SoftDeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler RefreshEvent;
        #endregion

        #region Implemented Functions
        public void SetUserListBindingSource(BindingSource userList)
        {
            userListGridView.DataSource = userList;
            userListGridView.Columns["Id"].Visible = false;
            userListGridView.Columns["Password"].Visible = false;
            userListGridView.Columns["Is_deleted"].Visible = false;
        }

        public void PopulateRole(List<ComboModel> roleList)
        {
            cbUserRole.DataSource = roleList;
            cbUserRole.ValueMember = "Value";
            cbUserRole.DisplayMember = "Name";
        }

        public void PopulateRoleFilter(List<ComboModel> roleList)
        {
            roleList[0].Name = "All";
            cbRoleFilter.DataSource = roleList;
            cbRoleFilter.ValueMember = "Value";
            cbRoleFilter.DisplayMember = "Name";
        }
        public void InitializeFilters()
        {
            StatusFilter = "0";

        }
        public void ShowUserManage()
        {
            tcUser.TabPages.Remove(tpUserList);
            tcUser.TabPages.Add(tpUserManage);
        }
        #endregion

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
