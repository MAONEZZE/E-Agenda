using e_Agenda.Dominio.ModuloDespesas;

namespace e_Agenda.Infra.Arquivo.ModuloDespesa
{
    public class RepositorioArquivoDespesa : RepositorioArquivoBase<Despesa>
    {
        public RepositorioArquivoDespesa()
        {
            listaRegistros = Desserializador();
        }
    }
}
