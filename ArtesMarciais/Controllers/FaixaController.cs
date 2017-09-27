using ArtesMarciais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtesMarciais.Controllers
{
    public class FaixaController : Controller
    {
        //
        // GET: /Faixa/
        private ApplicationDbContext _context;
        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var faixa = _context.Faixa.ToList();
            return View(faixa);
        }
        public ActionResult Details(int Id)
        {
            var faixas = _context.Faixa.SingleOrDefault(c => c.id == Id);


            if (faixas == null)
                return HttpNotFound();

            return View(faixas);
        }
	}
}