using System.ComponentModel.DataAnnotations;

namespace BlazorWasm.Models
{
    public class ListaTarefas
    {
        public int Id { get; set; } = 1;

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Titulo { get; set; }
        public List<Tarefa> Tarefas { get; set; } = new();
    }
}
