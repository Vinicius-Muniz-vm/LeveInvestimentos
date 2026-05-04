using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using LeveInvestimentos.Data;
using LeveInvestimentos.Models;
using System.Linq;

namespace LeveInvestimentos.Controllers
{
    public class TaskController : Controller
    {
        private readonly AppDbContext _db;

        public TaskController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.IsGestor = HttpContext.Session.GetString("IsGestor") == "true" || HttpContext.Session.GetString("IsGestor") == "True";
            return View(_db.Tasks.ToList());
        }

        public IActionResult Create()
        {
            var isGestor = HttpContext.Session.GetString("IsGestor");
            
            if (string.IsNullOrEmpty(isGestor) || isGestor.ToLower() != "true")
            {
                return Content("Acesso Negado: Apenas gestores logados podem criar novas tarefas. Por favor, volte e faça o login na página inicial.");
            }

            ViewBag.Users = _db.Users.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            var isGestor = HttpContext.Session.GetString("IsGestor");
            
            if (string.IsNullOrEmpty(isGestor) || isGestor.ToLower() != "true")
            {
                return Content("Acesso Negado: Apenas gestores logados podem criar novas tarefas.");
            }

            task.Status = "Pendente";
            _db.Tasks.Add(task);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Concluir(int id)
        {
            var task = _db.Tasks.Find(id);
            if (task != null)
            {
                task.Status = "Concluido";
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
