using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult app()
        {
            return View();
        }
        [HttpPost]
        public ActionResult app(Questions newQ)
        {
            TempData["Key"] = JsonConvert.SerializeObject(newQ);
            return RedirectToAction("Index");                     
        }
        public ActionResult Index()
        {
            if(TempData["Key"] == null)
            {
                return RedirectToAction("Error");
            }
            Questions ans = JsonConvert.DeserializeObject<Questions>(TempData["Key"].ToString());
            
            string wou = ans.way_of_usage;
            string p = ans.purpose;
            string fone = ans.feature1;
            string ftwo = ans.feature2;
            string fthree = ans.feature3;
            string ffour = ans.feature4;
            string ffive = ans.feature5;
            string fsix = ans.feature6;
            string fseven = ans.feature7;
            string feight = ans.feature8;
            
            PracaEntities2 db = new PracaEntities2();
            string query = $"SELECT * FROM Car WHERE {wou} {p} {fone} {ftwo} {fthree} {ffour} {ffive} {fsix} {fseven} {feight};";

            try
            {              
                var data = db.Database.SqlQuery<CarViewModel>(query).ToList();
                return View(data);
            }
            catch (System.NullReferenceException f)
            {
                return RedirectToAction("Error");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                return RedirectToAction("Error");
            }           
        }
        
        public ActionResult Error()
        {
            return View();
        }
        
    }
}