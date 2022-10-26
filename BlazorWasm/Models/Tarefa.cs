using System.ComponentModel.DataAnnotations;

namespace BlazorWasm.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Titulo { get; set; }
        public bool Feito { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        public DateTime AtualizadoEm { get; set; } = DateTime.Now;
    }
}
