namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class EntidadeBase<TEntidade>
    {
        public int id { get; set; }
        public abstract void AtualizarInformacoes(TEntidade registrosAtualizados);
        public abstract string[] Validar();
    }
}
