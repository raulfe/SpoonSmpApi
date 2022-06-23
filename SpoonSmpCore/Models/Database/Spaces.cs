using SpoonSmpCore.Models.Base;
using System;

#nullable disable

namespace SpoonSmpCore.Models.Database
{
    public partial class Spaces : BaseEntity
    {
        public string SpaceName { get; set; }
        public string MorningReservationCode { get; set; }
        public string MorningAvailable { get; set; }
        public string NightReservationCode { get; set; }
        public string NightAvailable { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
