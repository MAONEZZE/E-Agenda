using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.Infra.Arquivo.ModuloTarefa
{
    public class RepositorioArquivoItemTarefa : RepositorioArquivoBase<ItemTarefa>
    {
        public RepositorioArquivoItemTarefa()
        {
            listaRegistros = Desserializador();
        }
    }
}
