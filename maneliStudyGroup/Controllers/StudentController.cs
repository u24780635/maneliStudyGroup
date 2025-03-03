using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace maneliStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentList()
        {
            List<Models.Students> info = new List<Models.Students>();

            info.Add(new Models.Students { StudentNumber = "u23864118", Name = "Muhammad", Surname = "Ismali", Email = "u23864118@tuks.co.za" });
            info.Add(new Models.Students { StudentNumber = "u24780635", Name = "Thandolwethu", Surname = "Maneli", Email = "u24780635@tuks.co.za" });
            info.Add(new Models.Students { StudentNumber = "u24575764", Name = "Megan", Surname = "Norval", Email = "u24575764@tuks.co.za" });
            info.Add(new Models.Students { StudentNumber = "u24981088", Name = "Demarcus", Surname = "Le Roux", Email = "u249810888@tuks.co.za" });
            info.Add(new Models.Students { StudentNumber = "u24653498", Name = "Lethokuhle", Surname = "Mabanga", Email = "uu24653498@tuks.co.za" });

            return View(info);
           
        }
    }
}