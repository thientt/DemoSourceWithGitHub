using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ical.Net;
using Ical.Net.Interfaces.DataTypes;
using NodaTime;
using Ical.Net.DataTypes;
using Ical.Net.Interfaces.Serialization.Factory;
using Ical.Net.Interfaces.Serialization;
using Ical.Net.Serialization;
using System.Text;

namespace WebAppICall.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DemoCalendar(string downloadFileName)
        {
            Ical.Net.Calendar cal = new Calendar();
            //Create the event, and add it to the Calendar
            Event evt = cal.Create<Event>();
            //Set information about for the event
            evt.Start = CalDateTime.Now;
            evt.End = evt.Start.AddHours(1);
            evt.Description = "Meeting project Siberia";
            evt.Location = "At Meeting room";
            evt.Priority = 0;
            evt.Status = EventStatus.Confirmed;
            ISerializationContext ctx = new SerializationContext();
            ISerializerFactory factory = new Ical.Net.Serialization.iCalendar.Factory.SerializerFactory();

            var serializer = factory.Build(cal.GetType(), ctx) as IStringSerializer;

            var output = serializer.SerializeToString(cal);

            var bytes = Encoding.UTF8.GetBytes(output);

            return this.File(bytes, "text/calendar", downloadFileName);

            //return View();
        }
    }
}