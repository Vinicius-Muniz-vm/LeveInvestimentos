using System;

namespace LeveInvestimentos.Models
{
    public class User
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string FotoUrl { get; set; }
        public bool IsGestor { get; set; }
    }
}
