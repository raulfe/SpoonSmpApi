using SpoonSmpCore.Models.Base;
using System;

#nullable disable

namespace SpoonSmpCore.Models.Database
{
    public partial class RegistedUser : BaseEntity
    {
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string Email { get; set; }
        public string ReservationCode { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
