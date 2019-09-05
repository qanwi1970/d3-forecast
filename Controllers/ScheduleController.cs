using System.Collections.Generic;
using forecast.Models;
using forecast.Services;
using Microsoft.AspNetCore.Mvc;

namespace forecast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService scheduleService;

        public ScheduleController(IScheduleService _scheduleService)
        {
            scheduleService = _scheduleService;
        }

        // GET: api/Schedule
        [HttpGet]
        public IEnumerable<Schedule> Get(bool? active)
        {
            if (active.GetValueOrDefault())
            {
                return scheduleService.GetActiveSchedules();
            }
            else
            {
                return scheduleService.GetAllSchedules();
            }
        }

        // GET: api/Schedule/5
        [HttpGet("{id}", Name = "Get")]
        public Schedule Get(int id)
        {
            return scheduleService.GetSchedule(id);
        }

        // POST: api/Schedule
        [HttpPost]
        public void Post([FromBody] Schedule value)
        {
            scheduleService.AddSchedule(value);
        }

        // PUT: api/Schedule/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Schedule value)
        {
            scheduleService.UpdateSchedule(id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            scheduleService.DeleteSchedule(id);
        }
    }
}
