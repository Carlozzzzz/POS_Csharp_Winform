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
        private string message;

        public LoginView()
        {
            InitializeComponent();

            btnLogin.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
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

        public event EventHandler LoginEvent;
        public event EventHandler CancelEvent;

        public void ShowErroredMessage() => MessageBox.Show(Message, "Error kinemberluw!");

        public void ShowMessage() => MessageBox.Show(Message, "Welcome!");
    }
}
