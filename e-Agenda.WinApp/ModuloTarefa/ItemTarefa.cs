
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
    }
}
