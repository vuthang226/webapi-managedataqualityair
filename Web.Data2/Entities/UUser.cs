using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class UUser
    {
        public UUser()
        {
            UUserRoles = new HashSet<UUserRole>();
        }

        public int Oid { get; set; }
        public string Userid { get; set; }
        public string Username { get; set; }
        public string Displayname { get; set; }
        public string Emailaddress { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthday { get; set; }
        public string Sex { get; set; }
        public string Phonenumber { get; set; }
        public string Image { get; set; }
        public bool? Lockaccount { get; set; }
        public bool? Passwordencrypted { get; set; }
        public bool? PasswordReset { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        public bool? Isactive { get; set; }
        public long? TimeRegister { get; set; }
        public long? TimeResetPwd { get; set; }
        public DateTime? LasttimeAccess { get; set; }
        public string Companyname { get; set; }
        public string Website { get; set; }

        public virtual ICollection<UUserRole> UUserRoles { get; set; }
    }
}
