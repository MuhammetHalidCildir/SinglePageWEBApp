using SinglePageWebApp.Models;
using SinglePageWebApp.Models.Entities;
using System.Linq;
using System.Web.Mvc;

namespace SinglePageWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var _db = new SPContext())
            {
                //View model oluşturuldu.
                IndexViewModel m = new IndexViewModel();
                m.PageTitle = "İlker \"Yolunda Gerek\" Turan";
                m.SubTitle = "Digital Nomad, Instructor";
                m.Sections = _db.Sections.Include("Icons").ToList();
                //İlgili View'e oluşturulan model gönderildi.
                return View(m);
            }
        }

    }
}