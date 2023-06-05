using e_Agenda.Dominio.ModuloCategoriaDespesa;

namespace e_Agenda.Infra.Memoria.ModuloCategoriaDespesa
{
    public class RepositorioMemoriaCategoria : RepositorioMemoriaBase<CategoriaDespesa>
    {
        public RepositorioMemoriaCategoria(List<CategoriaDespesa> listaCategorias)
        {
            this.listaRegistros = listaCategorias;
        }
    }
}
