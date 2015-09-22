using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using ArduinoSerialWeb.SerialCommunication;

namespace ArduinoSerialWeb.Controllers
{
    public class HomeController : Controller
    {
		public SerialCommunicator Serial;
           
        public HomeController()
        {
			Serial = new SerialCommunicator();
        }

        public ActionResult Index(int input = -1)
        {
            if (input == 1)
            {
                Serial.Write("1");
                Console.WriteLine("sent: 1");
            }

            if (input == 0)
            {
                Serial.Write("0");
                Console.WriteLine("sent: 0");
            }

            return View();
        }
    }
}