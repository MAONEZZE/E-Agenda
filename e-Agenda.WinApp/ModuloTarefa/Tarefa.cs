using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>//Model, Entidade
    {
        public string titulo;
        public PrioridadeTarefa prioridade;
        public DateTime data;
        public List<ItemTarefa> listaItens;
        public decimal percConcluido;

        public Tarefa(string titulo, PrioridadeTarefa prioridade, DateTime data)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.data = data;
            this.listaItens = new List<ItemTarefa>();
        }

        public int QuantItens
        {
            get
            {
                return listaItens.Count;
            }
        }

        public enum PrioridadeTarefa
        {
            Nenhum, Alta, Media, Baixa
        }

        public override void AtualizarInformacoes(Tarefa registrosAtualizados)
        {
            this.data = registrosAtualizados.data;
            this.titulo = registrosAtualizados.titulo;
            this.prioridade = registrosAtualizados.prioridade;
        }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
            {
                listaErros.Add("O campo do titulo é obrigatorio!");
            }
            else if (prioridade == PrioridadeTarefa.Nenhum)
            {
                listaErros.Add("Os botões de prioridades são obrigatorios!");
            }

            return listaErros.ToArray();
        }

        public void AdicionarItens(ItemTarefa item)
        {
            listaItens.Add(item);
            CalcPercentual();
        }

        public void ConcluirItem(ItemTarefa itemTarefa)
        {
            ItemTarefa itemSelecionado = null;

            foreach (ItemTarefa item in listaItens)
            {
                if (item.Equals(itemTarefa))
                {
                    itemSelecionado = item;
                    break;
                }
            }
            //ou ItemTarefa itemSelecionado = listaItens.FirstOrDefault(x => x.Equals(itemTarefa));

            if (itemSelecionado != null)
            {
                itemSelecionado.Concluir();

                CalcPercentual();
            }
        }

        public void DesmarcarItem(ItemTarefa itemTarefa)
        {
            ItemTarefa itemSelecionado = null;

            foreach (ItemTarefa item in listaItens)
            {
                if (item.Equals(itemTarefa))
                {
                    itemSelecionado = item;
                    break;
                }
            }

            if (itemSelecionado != null)
            {
                itemSelecionado.Desmarcar();

                CalcPercentual();
            }
        }

        private void CalcPercentual()
        {
            decimal quantItens = listaItens.Count();
            decimal contador = 0;

            foreach (ItemTarefa item in listaItens)
            {
                if(item.status == ItemTarefa.StatusPendenciaEnum.Concluido)
                {
                    contador++;
                }
            }

            this.percConcluido = Math.Round(contador * 100 / quantItens);

        }
    }
}
