using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BTL_QLBH.Models;
namespace BTL_QLBH.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        Encrytion encry = new Encrytion();
        QLBHDbContext db = new QLBHDbContext();
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Register(Account acc)
        {
            if(ModelState.IsValid)
            {
                acc.PassWord = encry.PassWordEncrytion(acc.PassWord);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Accounts");
            }
            return View(acc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(Account acc)
        {
            if(ModelState.IsValid)
            {
                string encrytionpass = encry.PassWordEncrytion(acc.PassWord);
                var model = db.Accounts.Where(m => m.UserName == acc.UserName && m.PassWord == encrytionpass).ToList().Count();
                //Thông tin đăng nhập chính xác
                if(model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.UserName, true);
                    return RedirectToAction("Index", "Home");
                } 
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không chính xác ");
                }  
            }
            return View(acc);
        }
        public ActionResult Loggout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");

        }

    }

}