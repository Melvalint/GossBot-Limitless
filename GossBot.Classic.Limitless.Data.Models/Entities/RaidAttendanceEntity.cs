using System;

namespace GossBot.Classic.Data.Models.Entities
{
    public class RaidAttendanceEntity
    {
        public int ID { get; set; }
        public DateTime RaidDate { get; set; }
        public int RaiderID { get; set; }
    }
}
