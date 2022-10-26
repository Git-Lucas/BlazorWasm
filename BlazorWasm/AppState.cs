using BlazorWasm.Models;

namespace BlazorWasm
{
    public static class AppState
    {
        public static List<ListaTarefas> Listas { get; set; } = new();
        public static event EventHandler<EventArgs> OnChanged;

        public static void NotifyChanges(object? sender, EventArgs args)
        {
            OnChanged.Invoke(sender, args);
        }
    }
}
