using POS_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_V1.Views
{
    public interface ILoginView
    {
        string Id { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Message { get; set; }
        UserRole Role { get; set; }
        bool IsSuccessful { get; set; }

        event EventHandler LoginEvent;
        event EventHandler CancelEvent;

        DialogResult DialogResult { get; set; }
        void Close();
    }
}
