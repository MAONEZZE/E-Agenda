using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Infra.Memoria.ModuloContato
{
    public class RepositorioMemoriaContato : RepositorioMemoriaBase<Contato>
    {
        public RepositorioMemoriaContato(List<Contato> listaContato)
        {
            listaRegistros = listaContato;
        }
    }
}
