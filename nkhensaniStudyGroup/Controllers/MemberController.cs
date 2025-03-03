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
            new Member() { StdNumber = "u23637341", StdName = "Nkateko", StdSurname = "Notigo", StdEmail = "u23637341@tuks.co.za" } ,
            new Member() { StdNumber = "u24885062" , StdName = "Tumiso", StdSurname = "Matlala", StdEmail = "u24885062@tuks.co.za" } ,
            new Member() { StdNumber = "u23641925" , StdName = "Nkhensani", StdSurname = "Notigo", StdEmail = "u23641925@tuks.co.za" } ,
            new Member() { StdNumber = "u24683729" , StdName = "Iviwe", StdSurname = "Vikwa", StdEmail = "u24683729@tuks.co.za" } ,
            new Member() { StdNumber = "u24979962", StdName = "Sivuyisiwe", StdSurname = "Ngalo", StdEmail = "u24979962@tuks.co.za" }
        };

        // GET: Member
        public ActionResult Index()
        {
            return View(memberList);
        }   

        public ActionResult Add_Member()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_Member(Member newMember)
        {
            if (ModelState.IsValid)
            {
                memberList.Add(newMember);
                return RedirectToAction("Index");
            }
            return View(newMember);
        }
    }


}