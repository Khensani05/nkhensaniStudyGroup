using nkhensaniStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nkhensaniStudyGroup.Controllers
{
    public class MemberController : Controller
    {
        //create static data 
        static IList<Member> memberList = new List<Member>
        {
            new Member() { StdNumber = "u01234567", StdName = "Jane", StdSurname = "Doe", StdEmail = "jane.doe@tuks.co.za" } ,
            new Member() { StdNumber = "u12345678" , StdName = "John", StdSurname = "Doe", StdEmail = "john.doe@tuks.co.za" } ,
            new Member() { StdNumber = "u23641925" , StdName = "Nkhensani", StdSurname = "Notigo", StdEmail = "u23641925@tuks.co.za" } ,
            new Member() { StdNumber = "u21642319" , StdName = "Omphile", StdSurname = "Ngwenya", StdEmail = "omphile@tuks.co.za" } ,
            new Member() { StdNumber = "u22687422", StdName = "Patience", StdSurname = "Sekwalo", StdEmail = "ekwalo@tuks.co.za" }
        };

        // GET: Member
        public ActionResult Index()
        {
            return View();
        }
    }
}