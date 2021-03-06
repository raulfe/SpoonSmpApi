using SpoonSmpCore.Models.Base;
using System;

#nullable disable

namespace SpoonSmpCore.Models.Database
{
    public partial class SystemUser : BaseEntity
    {
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int Privilege { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
