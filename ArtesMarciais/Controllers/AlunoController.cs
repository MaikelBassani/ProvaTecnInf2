using ArtesMarciais.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtesMarciais.Controllers
{
    public class AlunoController : Controller
    {
        //
        // GET: /Aluno/
        private ApplicationDbContext _context;
        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var alunos = _context.Aluno.Include(c => c.faixa).Include(c => c.TipodeAssociacao).ToList();
            return View(alunos);
        }
        public ActionResult Details(int Id)
        {
            var alunos = _context.Aluno.Include(c => c.faixa).Include(c => c.TipodeAssociacao).SingleOrDefault(c => c.id == Id);


            if (alunos == null)
                return HttpNotFound();

            return View(alunos);
        }
	}
}