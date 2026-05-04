using System;

namespace LeveInvestimentos.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLimite { get; set; }
        public int UsuarioId { get; set; }
        public int GestorId { get; set; }
        public string Status { get; set; }
    }
}
