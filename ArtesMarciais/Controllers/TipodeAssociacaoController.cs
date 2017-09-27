using ArtesMarciais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtesMarciais.Controllers
{
    public class TipodeAssociacaoController : Controller
    {
        //
        // GET: /TipodeAssociacao/
        private ApplicationDbContext _context;
        public  TipodeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var tipo = _context.TipodeAssociacao.ToList();
            return View(tipo);
        }
        public ActionResult Details(int Id)
        {
            var tipos = _context.TipodeAssociacao.SingleOrDefault(c => c.id == Id);


            if (tipos == null)
                return HttpNotFound();

            return View(tipos);
        }
	}
}