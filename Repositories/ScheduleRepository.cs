using System;
using System.Collections.Generic;
using System.Linq;
using forecast.Db;
using forecast.Models;

namespace forecast.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        public Schedule AddSchedule(Schedule schedule)
        {
            using (var context = new ForecastContext())
            {
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            return schedule;
        }

        public void DeleteSchedule(int scheduleId)
        {
            using (var context = new ForecastContext())
            {
                var schedule = context.Schedules.Find(scheduleId);
                context.Schedules.Remove(schedule);
                context.SaveChanges();
            }
        }

        public IList<Schedule> GetActiveSchedules()
        {
            var now = DateTime.UtcNow;
            using (var context = new ForecastContext())
            {
                return context.Schedules
                    .Where(s => (s.Begin == null || s.Begin <= now) && (s.End == null || s.End >= now))
                    .ToList();
            }
        }

        public IList<Schedule> GetAllSchedules()
        {
            using (var context = new ForecastContext())
            {
                return context.Schedules.ToList();
            }
        }

        public Schedule GetSchedule(int scheduleId)
        {
            using (var context = new ForecastContext())
            {
                return context.Schedules.Find(scheduleId);
            }
        }

        public Schedule UpdateSchedule(int scheduleId, Schedule schedule)
        {
            using (var context = new ForecastContext())
            {
                var origSchedule = context.Schedules.Find(scheduleId);
                if (origSchedule.Name != schedule.Name) origSchedule.Name = schedule.Name;
                if (origSchedule.Amount != schedule.Amount) origSchedule.Amount = schedule.Amount;
                if (origSchedule.ScheduleType != schedule.ScheduleType) origSchedule.ScheduleType = schedule.ScheduleType;
                if (origSchedule.Value != schedule.Value) origSchedule.Value = schedule.Value;
                if (origSchedule.Begin != schedule.Begin) origSchedule.Begin = schedule.Begin;
                if (origSchedule.End != schedule.End) origSchedule.End = schedule.End;
                context.SaveChanges();
                return origSchedule;
            }
        }
    }
}
