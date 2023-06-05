namespace e_Agenda.Dominio.Compartilhado
{
    public abstract class EntidadeBase<TEntidade>
    {
        public int id { get; set; }
        public abstract void AtualizarInformacoes(TEntidade registrosAtualizados);
        public abstract string[] Validar();

        //public abstract JSONObject CarregarJSON();
    }
}
