using forecast.Models;
using forecast.Repositories;
using System.Collections.Generic;

namespace forecast.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository scheduleRepository;

        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            this.scheduleRepository = scheduleRepository;
        }

        public void AddSchedule(Schedule value)
        {
            scheduleRepository.AddSchedule(value);
        }

        public void DeleteSchedule(int id)
        {
            scheduleRepository.DeleteSchedule(id);
        }

        public IEnumerable<Schedule> GetActiveSchedules()
        {
            return scheduleRepository.GetActiveSchedules();
        }

        public IList<Schedule> GetAllSchedules()
        {
            return scheduleRepository.GetAllSchedules();
        }

        public Schedule GetSchedule(int id)
        {
            return scheduleRepository.GetSchedule(id);
        }

        public void UpdateSchedule(int id, Schedule value)
        {
            scheduleRepository.UpdateSchedule(id, value);
        }
    }
}
