using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1.Models
{
    public class LoginModel
    {
        private int id;
        private string username;
        private string password;
        private UserRole role;

        //Properties
        [DisplayName("Id")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be 3 - 50 characters.")]       
        public string Username { get => username; set => username = value; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password must be 3 - 50 characters.")]
        public string Password { get => password; set => password = value; }
        public UserRole Role { get => role; set => role = value; }
    }
}
