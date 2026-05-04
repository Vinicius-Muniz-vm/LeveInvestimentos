using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using LeveInvestimentos.Data;
using LeveInvestimentos.Models;
using System.Linq;

namespace LeveInvestimentos.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _db;

        public AuthController(AppDbContext db)
        {
            _db = db;

            if (!_db.Users.Any())
            {
                _db.Users.Add(new User
                {
                    NomeCompleto = "Admin",
                    Email = "ti@leveinvestimentos.com.br",
                    Senha = "teste123",
                    IsGestor = true
                });
                _db.SaveChanges();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var user = _db.Users.FirstOrDefault(x => x.Email == email && x.Senha == senha);

            if (user == null)
            {
                ViewBag.Error = "Email ou senha incorretos";
                return View();
            }

            HttpContext.Session.SetString("UserEmail", user.Email);
            HttpContext.Session.SetString("IsGestor", user.IsGestor.ToString());

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult EsqueciSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EsqueciSenha(string email)
        {
            ViewBag.Message = "Instruções enviadas para o seu e-mail";
            return View();
        }
    }
}
