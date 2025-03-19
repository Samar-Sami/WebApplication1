using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.controllers
{
    public class HomeController : Controller
    //Home    اما بتعامل هكتب 
    {
        //int or string   نادرا  مايرجع mvcال  
        public ActionResult Index()

        //    add view  - r.clickاعمل   action هاجي ع .. view  .. action  لو عايزه اعمل لل 
        //    Controller  بيكون اسم ال  view  غالبا اسم ال
        // method انها  function  بنقول ع ال
        {
            return View();
        }


        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
            }


   

        public ActionResult Ind()
        {
            ContentResult result = new ContentResult();
            result.Content = "string.Empty";
            return result;
        }


        //helper method
        public ActionResult Inde()
        {
           
            return Content("ads");
        }

        public ActionResult Inde2()
        {

            return  Redirect ("https://drive.google.com/drive/folders/1B4LSkY9-CsC55oExo0m5AtWAlMv6Fk1K");
        }

        public ActionResult Inde3()
        {
            // anoher action  بس توديتي ع project  ع حاجه في نفس ال  Routing  لو عايزه  اعمل   
            return RedirectToAction("Index");
        }



    }
} 
