using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Infra.Arquivo.ModuloContato
{
    public class RepositorioArquivoContato : RepositorioArquivoBase<Contato>
    {
        public RepositorioArquivoContato()
        {
            listaRegistros = Desserializador();
        }
    }
}
