using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1.Models
{
    public class UserFilterModel : UserModel
    {
        private int role_filter;
        private DateTime from_date_filter;
        private DateTime to_date_filter;

        [DisplayName("Role Filter")]
        public int RoleFilter { get => role_filter; set => role_filter = value; }
        [DisplayName("Date From")]
        public DateTime FromDateFilter { get => from_date_filter; set => from_date_filter = value; }
        [DisplayName("Date To")]
        public DateTime ToDateFilter { get => to_date_filter; set => to_date_filter = value; }
    }
}
