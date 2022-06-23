using System;

#nullable disable

namespace SpoonSmpCore.Models.Database
{
    public partial class AuditEvent
    {
        public int UniqId { get; set; }
        public string AuditType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Description { get; set; }
        public string TableName { get; set; }
        public DateTime? Xdate { get; set; }
        public string Xuser { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Pkey { get; set; }
    }
}
