namespace e_Agenda.Dominio.ModuloTarefa
{
    public class ItemTarefa : EntidadeBase<ItemTarefa>
    {
        public string descricao { get; set; }
        public StatusPendenciaEnum status { get; set; }

        public ItemTarefa(string descricao, StatusPendenciaEnum status)
        {
            this.descricao = descricao;
            this.status = status;
        }

        public ItemTarefa()
        {
            
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

        public override void AtualizarInformacoes(ItemTarefa registrosAtualizados){}

        public override string[] Validar(){ return null; }

    }
}
