using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using LeveInvestimentos.Data;
using LeveInvestimentos.Models;
using System.Linq;

namespace LeveInvestimentos.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _db;

        public UserController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.IsGestor = HttpContext.Session.GetString("IsGestor") == "true" || HttpContext.Session.GetString("IsGestor") == "True";
            return View(_db.Users.ToList());
        }

        public IActionResult Create()
        {
            var isGestor = HttpContext.Session.GetString("IsGestor");
            
            if (string.IsNullOrEmpty(isGestor) || isGestor.ToLower() != "true")
            {
                return Content("Acesso Negado: Apenas gestores logados podem criar novos usuários. Por favor, volte e faça o login na página inicial.");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Create(User user, string ConfirmacaoSenha)
        {
            var isGestor = HttpContext.Session.GetString("IsGestor");
            
            if (string.IsNullOrEmpty(isGestor) || isGestor.ToLower() != "true")
            {
                return Content("Acesso Negado: Apenas gestores logados podem criar novos usuários.");
            }

            if (user.Senha != ConfirmacaoSenha)
            {
                ViewBag.Error = "A senha e a confirmação de senha não conferem.";
                return View(user);
            }

            _db.Users.Add(user);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
