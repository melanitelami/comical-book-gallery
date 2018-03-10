using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comical_book_gallery.Controllers
{
    public class ComicBooksController :Controller
    {
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return Redirect("/");
               // return new  RedirectResult("/");
            }
            return Content("Hello from comic books Controller");

       // ========    return new ContentResult
       //     {
       //         Content = "Hello from comic books Controller"

            //     };=======
        }
    }
}