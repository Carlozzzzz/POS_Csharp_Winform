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
        UserRole Role { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Status { get; set; }
        bool IsDeleted { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string SearchValue { get; set; }
        string Message { get; set; }
        string MessageType { get; set; }
        int RoleFilter { get; set; }
        string StatusFilter { get; set; }
        DateTime FromDateFilter { get; set; }
        DateTime ToDateFilter { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler FilterEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler SoftDeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler RefreshEvent;

        // Methods
        void SetUserListBindingSource(BindingSource userList);
        void ShowUserManage();
        void PopulateRole(List<ComboModel> roleList);
        void PopulateRoleFilter(List<ComboModel> roleList);
        void InitializeFilters();
        void Show();
    }
}
