using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using angulardemomvc2.DAL;
using System.Data.Entity;
using angulardemomvc2.Models;

namespace angulardemomvc2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        PersonContext data = new PersonContext();
        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult GetDataListFriend() {

            //List<Person> listFriend = new List<Person>();
            //Person friend = new Person();
            //friend.ID = 1;
            //friend.Name = "tan";
            //friend.Address = "dn";
            //friend.Phone = "00011";
            //data.Persons.Add(friend);
            //data.SaveChanges();
            //listFriend = (from data in data.Persons select data).ToList();

            //            var jsonResult =  [ "name": "Media Relations","email": "press@udemy.com",
            //"notes": "Member of the media? We'd love to hear from you."
            //},
            //{
            //                "name": "Business Development",
            //"email": "bizdev@udemy.com",
            //"notes": "For general business development inquiries."
            //}
            //];
            //            var employeeList = JsonConvert.SerializeObject(jsonResult);
            //            //List<string> stringJson = new List<string>();
            //            //for(int i =1; i< 10;i++)
            //            //{
            //            //    stringJson.Add("EmployteeId" + ":" + i.ToString() +","+ "EmployeeName" + ":" + i.ToString()+"," + "Address" + ":"+ 500 +","+ "EmailId" + ":" +"da");
            //            //}
            //            //var employeeList = JsonConvert.SerializeObject(stringJson.ToList());
            //            return Json(employeeList, JsonRequestBehavior.AllowGet);
            //var employeeList = JsonConvert.SerializeObject(listFriend);
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}
