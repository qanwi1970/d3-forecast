using forecast.Models;
using System.Collections.Generic;

namespace forecast.Services
{
    public interface IScheduleService
    {
        IList<Schedule> GetAllSchedules();
        IEnumerable<Schedule> GetActiveSchedules();
        Schedule GetSchedule(int id);
        void AddSchedule(Schedule value);
        void UpdateSchedule(int id, Schedule value);
        void DeleteSchedule(int id);
    }
}
