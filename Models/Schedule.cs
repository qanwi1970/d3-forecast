using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace forecast.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Amount { get; set; }

        [Required]
        public ScheduleType ScheduleType { get; set; }

        [Required]
        public string Value { get; set; }

        public DateTime Begin { get; set; }

        public DateTime End { get; set; }
    }

    public enum ScheduleType
    {
        MONTHLY,
        WEEKLY,
        SPECIAL
    }

    public enum SpecialSchedules
    {
        EOM,
        PAYDAY_EOM,
        PAYDAY_15
    }
}
