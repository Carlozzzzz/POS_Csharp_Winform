using POS_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_V1.Views
{
    public interface IUserView
    {

        // Properties
        string UserId { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string PasswordRepeat { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Role { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string SearchValue { get; set; }
        string Message { get; set; }
        string MessageType { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler SoftDeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetUserListBindingSource(BindingSource userList);
        void PopulateRole(List<ComboModel> roleList);
        void Show();
    }
}
