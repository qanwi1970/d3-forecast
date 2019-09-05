using forecast.Models;
using System.Collections.Generic;

namespace forecast.Repositories
{
    public interface IScheduleRepository
    {
        IList<Schedule> GetAllSchedules();

        Schedule GetSchedule(int scheduleId);

        IList<Schedule> GetActiveSchedules();

        Schedule AddSchedule(Schedule schedule);

        Schedule UpdateSchedule(int scheduleId, Schedule schedule);

        void DeleteSchedule(int scheduleId);
    }
}
