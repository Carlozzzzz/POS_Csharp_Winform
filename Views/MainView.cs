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
    public partial class MainView : Form, IMainView
    {
        private bool isLoggedOut;
        private string message;
        public MainView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

        }

        private void AssociateAndRaiseViewEvents()
        {
            btnLogout.Click += delegate {
                var result = MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    LogoutEvent?.Invoke(this, EventArgs.Empty);  
                }
            };

            btnDashboard.Click += delegate {
                ShowDashboardView?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };

            btnUsers.Click += delegate {
                ShowUserView?.Invoke(this, EventArgs.Empty);
                //MessageBox.Show(Message);
            };

            btnProducts.Click += delegate { 
                ShowProductView?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
        }

        public bool IsLoggedout { 
            get => isLoggedOut; 
            set => isLoggedOut = value; 
        }
        public string Username { 
            get => lblUserLoggedin.Text; 
            set => lblUserLoggedin.Text = value;
        }
        public string Message { 
            get => message; 
            set => message = value; 
        }

        public event EventHandler LogoutEvent;
        public event EventHandler ShowDashboardView;
        public event EventHandler ShowUserView;
        public event EventHandler ShowProductView;
    }
}
