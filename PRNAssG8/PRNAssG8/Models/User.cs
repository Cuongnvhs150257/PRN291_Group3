using System;
using System.Collections.Generic;

#nullable disable

namespace PRNAssG8.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public int Gender { get; set; }
        public int RoleId { get; set; }
        public int Status { get; set; }

        public virtual Role Role { get; set; }
    }
}
