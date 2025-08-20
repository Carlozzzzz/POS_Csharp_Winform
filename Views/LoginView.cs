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
    public partial class LoginView : Form, ILoginView
    {
        private string id;
        private UserRole role;
        private bool isSuccessful;
        private string message;

        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
           
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += delegate { 
                LoginEvent?.Invoke(this, EventArgs.Empty); 
                if (isSuccessful)
                {
                    MessageBox.Show("Logged in Success.");
                }
                else
                {
                    MessageBox.Show(Message);
                }
            };

            tbPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    LoginEvent?.Invoke(this, EventArgs.Empty);
                    if (isSuccessful)
                    {
                        MessageBox.Show("Logged in Success.");
                    }
                    else
                    {
                        MessageBox.Show(Message);
                    }
                }
                    
            };

            tbUsername.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    LoginEvent?.Invoke(this, EventArgs.Empty);
                    if (isSuccessful)
                    {
                        MessageBox.Show("Logged in Success.");
                    }
                    else
                    {
                        MessageBox.Show(Message);
                    }
                }
            };

            btnCancel.Click += delegate { 
                var result = MessageBox.Show("Are you sure you want to exit the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CancelEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string Id { 
            get => id; 
            set => id = value; 
        }
        public string Username { 
            get => tbUsername.Text; 
            set => tbUsername.Text = value; 
        }
        public string Password { 
            get => tbPassword.Text; 
            set => tbPassword.Text = value; 
        }
        public string Message { 
            get => message; 
            set => message = value; 
        }
        public UserRole Role { 
            get => role; 
            set => role = value; 
        }
        public bool IsSuccessful { 
            get => isSuccessful; 
            set => isSuccessful = value; 
        }

        public event EventHandler LoginEvent;
        public event EventHandler CancelEvent;

    }
}
