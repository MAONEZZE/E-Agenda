namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }
        public virtual string ToolTipFiltrar { get; }
        public virtual string ToolTipListar { get; }
        public virtual string ToolTipInserirItens { get; }
        public virtual string ToolTipVisualizarAbertos { get; }
        public virtual string ToolTipVisualizarConcluidos { get; }
        public virtual void Filtrar() { }
        public virtual void ItensConcluidos() { }
        public virtual void AddItem() { }
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract UserControl ObterListagem();
        public abstract string ObterTipoCadastro();
    }

}
