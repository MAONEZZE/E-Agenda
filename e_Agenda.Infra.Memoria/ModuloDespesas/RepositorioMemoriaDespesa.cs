using e_Agenda.Dominio.ModuloDespesas;

namespace e_Agenda.Infra.Memoria.ModuloDespesas
{
    public class RepositorioMemoriaDespesa : RepositorioMemoriaBase<Despesa>
    {
        public RepositorioMemoriaDespesa(List<Despesa> listaDespesas)
        {
            listaRegistros = listaDespesas;
        }
    }
}
