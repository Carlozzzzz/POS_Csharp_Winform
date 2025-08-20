using POS_V1.Models;
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

        public UserView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbSearch.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty);
                };
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
        public UserRole Role { 
            get => (UserRole)cbRole.SelectedValue; 
            set => cbRole.SelectedValue = value; 
        }
        public string Phone { 
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
        public string SearchValue
        {
            get => tbSearch.Text;
            set => tbSearch.Text = value;
        }
        #endregion

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler SoftDeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetUserListBindingSource(BindingSource userList)
        {
            userListGridView.DataSource = userList;
            userListGridView.Columns["Id"].Visible = false;
            userListGridView.Columns["Is_deleted"].Visible = false;

            Console.WriteLine("Displaying column names: " );
            foreach (DataGridViewRow row in userListGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Console.WriteLine($"Column: {cell.OwningColumn.Name}, Value: {cell.Value}");
                }
            }



        }

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

    }
}
