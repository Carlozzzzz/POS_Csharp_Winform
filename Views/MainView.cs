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
    public partial class MainView : Form , IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public event EventHandler ShowDashboardView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowUserView;
    }
}
