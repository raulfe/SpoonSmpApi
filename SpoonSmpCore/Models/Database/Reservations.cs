using SpoonSmpCore.Models.Base;
using System;

namespace SpoonSmpCore.Models.Database
{
    public class Reservations : BaseEntity
    {
        public string  Reservation_code { get; set; }
        public DateTime Reservation_time { get; set; }
    }
}
