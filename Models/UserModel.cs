using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_V1.Models
{
    public class UserModel
    {
        // Variables
        private int id;
        private string username;
        private string password;
        private string first_name;
        private string last_name;
        private UserRole role;
        private string email;
        private string phone;
        private string status;
        private bool is_deleted;
        private DateTime created_at;
        private DateTime updated_at;

        //Properties
        [DisplayName("User ID")]
        public int Id { get => id; set => id = value; }
        
        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters.")]
        public string Username { get => username; set => username = value; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "password must be between 3 and 50 characters.")]
        public string Password { get => password; set => password = value; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name must be between 3 and 50 characters.")]
        public string First_name { get => first_name; set => first_name = value; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name must be between 3 and 50 characters.")]
        public string Last_name { get => last_name; set => last_name = value; }

        [DisplayName("User Role")]
        [Required(ErrorMessage = "User role is required.")]
        //[EnumDataType(typeof(UserRole), ErrorMessage = "Invalid role.")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid role.")]
        public UserRole Role { get => role; set => role = value; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Email must be between 3 and 100 characters.")]
        public string Email { get => email; set => email = value; }

        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        [StringLength(20, MinimumLength = 9, ErrorMessage = "Phone number must be between 9 and 20 characters.")]
        public string Phone { get => phone; set => phone = value; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required.")]
        [Range(1, 2, ErrorMessage = "Invalid status.")]
        public string Status { get => status; set => status = value; }

        [DisplayName("Is Deleted")]
        public bool Is_deleted { get => is_deleted; set => is_deleted = value; }

        [DisplayName("Created At")]
        public DateTime Created_at { get => created_at; set => created_at = value; }

        [DisplayName("Updated At")]
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
