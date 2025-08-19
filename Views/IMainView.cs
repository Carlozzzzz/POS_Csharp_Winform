using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace POS_V1.Views
{
    public interface IMainView
    {
        bool IsLoggedout { get; set; }
        string Message { get; set; }

        event EventHandler LogoutEvent;
        event EventHandler ShowDashboardView;
        event EventHandler ShowUserView;
        event EventHandler ShowProductView;

        DialogResult DialogResult { get; set; }
        void Show();
        void Close();
        void Hide();


    }
}
