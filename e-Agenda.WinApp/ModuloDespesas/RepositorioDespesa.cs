namespace e_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {
        public RepositorioDespesa(List<Despesa> listaDespesas)
        {
            this.listaRegistros = listaDespesas;
        }
    }
}
