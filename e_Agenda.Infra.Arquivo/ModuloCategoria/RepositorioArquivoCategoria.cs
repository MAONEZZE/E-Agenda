using e_Agenda.Dominio.ModuloCategoriaDespesa;

namespace e_Agenda.Infra.Arquivo.ModuloCategoriaDespesa
{
    public class RepositorioArquivoCategoria : RepositorioArquivoBase<CategoriaDespesa>
    {
        public RepositorioArquivoCategoria()
        {
            this.listaRegistros = Desserializador();
        }
    }
}
