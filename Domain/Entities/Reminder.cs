using System;

namespace ARMB.Domain.Entities
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime ReminderDate { get; set; }
        public bool IsAcknowledged { get; set; }
    }
}
