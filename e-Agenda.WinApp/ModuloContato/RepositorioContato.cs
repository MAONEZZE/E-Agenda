using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public RepositorioContato(List<Contato> listaContato)
        {
            this.listaRegistros = listaContato;
        }
    }
}
