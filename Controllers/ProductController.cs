using LoadMoreMVCSample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoadMoreMVCSample.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var model = _db.Products.OrderBy(p => p.ProductId).Take(4); ;
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public JsonResult LoadMoreProduct(int size)
        {
            var model = _db.Products.OrderBy(p => p.ProductId).Skip(size).Take(4);
            int modelCount = _db.Products.Count();
            if (model.Any())
            {
                string modelString = RenderRazorViewToString("_LoadMoreProduct", model);

                return Json(new { ModelString = modelString, ModelCount = modelCount });
            }
            return Json(model);
        }
        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext,
                                                                         viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View,
                                             ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}