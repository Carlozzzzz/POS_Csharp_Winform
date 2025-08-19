using POS_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1.Views
{
    public interface ILoginView
    {
        string Id { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Message { get; set; }
        UserRole Role { get; set; }

        event EventHandler LoginEvent;
        event EventHandler CancelEvent;

        void ShowMessage();
        void ShowErroredMessage();
        void Show();
    }
}
