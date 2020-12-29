using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonCalendar.Calendar.Application.Interfaces;
using CommonCalendar.Calendar.Application.Models;
using CommonCalendar.Calendar.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommonCalendar.Calendar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CallendarController : Controller
    {
        private readonly ICalendarService _calendarService;

        public CallendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CalendarEvent>> Get()
        {
            return Ok(_calendarService.GetCalendarEvents());
        }
        [HttpPost]
        public ActionResult CreateCalendarEvent(CalendarEventDTO calendarEventDTO)
        {
            _calendarService.CreateCalendarEvent(calendarEventDTO);

            return Ok(calendarEventDTO);
        }
    }
}