using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wholesale.Models;

namespace Wholesale.Controllers
{
    public class BankController : Controller
    {
        private  bankDetailsEntities db = new bankDetailsEntities();
        // GET: Bank
        public ActionResult Index()
        {
            return View(db.AccountLists.ToList());
        }
        public ActionResult Transaction(string Id)
        {
            return View(db.AccountTransactions.Where(x=>x.AccountNumber==Id).ToList());
        }

    }
}