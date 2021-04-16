using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webpt.Models;

namespace webpt.Controllers
{
    public class QuanLySanPhamController : Controller
    {
        // GET: QuanLySanPham
        BanPhuTungXeEntities db = new BanPhuTungXeEntities();
        public ActionResult Index()
        {
            return View(db.SanPhams.ToList());
        }
    }
}