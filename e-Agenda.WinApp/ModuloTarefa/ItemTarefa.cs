
namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ItemTarefa
    {
        public string descricao;
        public StatusPendenciaEnum status;

        public ItemTarefa(string descricao, StatusPendenciaEnum status)
        {
            this.descricao = descricao;
            this.status = status;
        }

        public enum StatusPendenciaEnum
        {
            Pendente, Concluido
        }

        public override string ToString()
        {
            return $"Descrição: {descricao} | Status: {status.ToString()}";
        }

        public void Concluir()
        {
            status = StatusPendenciaEnum.Concluido;
        }

        public void Desmarcar()
        {
            status = StatusPendenciaEnum.Pendente;
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTarefa tarefa &&
                   descricao == tarefa.descricao &&
                   status == tarefa.status;
        }
    }
}
