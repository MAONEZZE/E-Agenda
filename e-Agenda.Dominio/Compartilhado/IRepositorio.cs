namespace e_Agenda.Dominio.Compartilhado
{
    public interface IRepositorio<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        public abstract void Inserir(TEntidade registro);

        public abstract void Editar(int id, TEntidade registroAtualizado);

        public abstract void Excluir(TEntidade registroSelecionado);

        public abstract List<TEntidade> SelecionarTodos();

    }
}
