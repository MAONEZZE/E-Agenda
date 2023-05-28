namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        protected List<TEntidade> listaRegistros;
        private int contadorRegistros = 0;

        public int Contador
        {
            get
            {
                return contadorRegistros;
            }
        }

        public virtual void Inserir(TEntidade registro)
        {
            registro.id = contadorRegistros;

            listaRegistros.Add(registro);

            contadorRegistros++;
        }

        public virtual void Editar(int id, TEntidade registroAtualizado)
        {
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Editar(TEntidade registroSelecionado, TEntidade registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Excluir(int id)
        {
            TEntidade registroSelecionado = SelecionarPorId(id);

            if (registroSelecionado != null)
                listaRegistros.Remove(registroSelecionado);
        }

        public virtual void Excluir(TEntidade registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);
        }

        public virtual TEntidade SelecionarPorId(int id)
        {

            foreach(TEntidade ent in listaRegistros)
            {
                if(ent.id == id)
                {
                    return ent;
                }
            }

            //if (listaRegistros.Exists(registro => registro.id == id))
              //  return listaRegistros.First(registro => registro.id == id);

            return null;
        }

        public virtual List<TEntidade> SelecionarTodos()
        {
            return listaRegistros.OrderByDescending(x => x.id).ToList();
        }
    }
}
