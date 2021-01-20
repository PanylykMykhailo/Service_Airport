using Airport.Models;
using Airport.Repositories;
using Airport.ViewModels;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Airport.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IScheduleRepository _scheduleRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICheckTrip _checkTrip;
        private readonly ITicketsRepository _ticketsRepository;
       
       

        private ApplicationDbContext db;
        

        public HomeController(ILogger<HomeController> logger, IScheduleRepository scheduleRepository, ITicketsRepository ticketsRepository, ICheckTrip checkTrip, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _checkTrip = checkTrip;
            _logger = logger;
            _scheduleRepository = scheduleRepository;
            _ticketsRepository = ticketsRepository;
            _userManager = userManager;
            db = context;
            


        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Schedule()
        {

            ScheduleViewModel flyout = new ScheduleViewModel();
            flyout = _scheduleRepository.Flightin();

            return View(flyout);
        }
        public IActionResult Schedule_In()
        {
            ScheduleViewModel flyin = new ScheduleViewModel();
            flyin = _scheduleRepository.Flightout();

            return View("Schedule", flyin);
        }
        [Authorize]
        public IActionResult Tickets()
        {
            TicketViewModel select1 = new TicketViewModel();
            select1 = _ticketsRepository.CityStart();

            return View(select1);

        }
        [HttpPost]

        public IActionResult CheckTrip(TicketViewModel search)
        {

            TicketViewModel select1 = new TicketViewModel();
            select1 = _ticketsRepository.CityStart();
            var result = _checkTrip.CheckTrip(search.searchTrip);
            select1.schedule = result.schedule;
            return View("Tickets", select1
            );
        }
        [HttpPost]
        public IActionResult Booking(string scheeduleId,string citystart)
        {
            if (citystart == "Львів")
            {
                var schedule_Out = db.Schedule_2.Include(a => a.CityStart).Include(a=>a.CityFinish).Where(a => a.CityStart.CityID.ToString() == scheeduleId).FirstOrDefault();
                AddViewModel addTicket = new AddViewModel();
                addTicket.schedule_Out = schedule_Out;
                return View("TicketReserved", addTicket
            );
            }
            else 
            {
                var schedule_In = db.Schedule_1.Include(a => a.CityStart).Include(a => a.CityFinish).Where(a => a.CityStart.CityID.ToString() == scheeduleId).FirstOrDefault();
                AddViewModel addTicket = new AddViewModel();
                addTicket.schedule_In = schedule_In;
                return View("TicketReserved", addTicket
            );
            }
        }
        [HttpPost]
        public IActionResult Renewal(string value)
        {
            if (value == null)
            {
                return RedirectToAction("Index");
            }
            else 
            {
                return RedirectToAction("Index");
            }

        }




        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(string myField)
        {
            if (myField != null)
            {
                Schedule_Out schedule_ = await db.Schedule_2.FirstOrDefaultAsync(p => p.ScheduleOutID.ToString() == myField);
                if (schedule_!= null)
                {

                    db.Schedule_2.Remove(schedule_);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Schedule");
                }
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Delete_In(string myField)
        {
            if (myField!= null)
            {
                Schedule_In schedule_ = await db.Schedule_1.FirstOrDefaultAsync(p => p.ScheduleID.ToString()==myField );
                if (schedule_ != null)
                {
                    db.Schedule_1.Remove(schedule_);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Schedule");
                }
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Create_Table_Out(Schedule_Out schedule_Out)
        {
            var cityStart = db.City.Where(a => a.CityName == schedule_Out.CityStart.CityName).FirstOrDefault();
            var cityFinish = db.City.Where(a => a.CityName == schedule_Out.CityFinish.CityName).FirstOrDefault();

            if (cityStart == null) 
            {
                
                db.City.Add(schedule_Out.CityStart);
                await db.SaveChangesAsync();
                cityStart= db.City.Where(a => a.CityName == schedule_Out.CityStart.CityName).FirstOrDefault();
            }
            if (cityFinish == null)
            {
                db.City.Add(schedule_Out.CityFinish);
                await db.SaveChangesAsync();
                cityFinish = db.City.Where(a => a.CityName == schedule_Out.CityFinish.CityName).FirstOrDefault();
                
            }
            schedule_Out.CityStart = cityStart;
            schedule_Out.CityFinish = cityFinish;

            db.Schedule_2.Add(schedule_Out);
            await db.SaveChangesAsync();
            return RedirectToAction("Schedule");
        }
        [HttpPost]
        public async Task<IActionResult> Create_Table_In(Schedule_In schedule_In)
        {
            var cityStartId = db.City.Where(a => a.CityName == schedule_In.CityStart.CityName).FirstOrDefault();
            var cityFinishId = db.City.Where(a => a.CityName == schedule_In.CityFinish.CityName).FirstOrDefault();

            if (cityStartId == null)
            {

                db.City.Add(schedule_In.CityStart);
                await db.SaveChangesAsync();
                cityStartId = db.City.Where(a => a.CityName == schedule_In.CityStart.CityName).FirstOrDefault();
            }
            if (cityFinishId == null)
            {
                db.City.Add(schedule_In.CityFinish);
                await db.SaveChangesAsync();
                cityFinishId = db.City.Where(a => a.CityName == schedule_In.CityFinish.CityName).FirstOrDefault();

            }
            schedule_In.CityStart = cityStartId;
            schedule_In.CityFinish = cityFinishId;

           
            db.Schedule_1.Add(schedule_In);
            await db.SaveChangesAsync();
            return RedirectToAction("Schedule");
        }
        [Authorize(Roles = "admin")]
        public IActionResult Add_Schedule()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
