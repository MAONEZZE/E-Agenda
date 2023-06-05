using e_Agenda.Dominio.ModuloCategoriaDespesa;

namespace e_Agenda.Dominio.ModuloDespesas
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public DateTime data { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public FormaPagamentoEnum pagamento { get; set; }
        public List<CategoriaDespesa> listaCategoriasChecked { get; set; }

        public Despesa()
        {
            
        }

        public Despesa(DateTime data, string descricao, decimal valor, FormaPagamentoEnum pagamento, List<CategoriaDespesa> listaCategoriasChecked)
        {
            this.data = data;
            this.descricao = descricao;
            this.valor = valor;
            this.pagamento = pagamento;
            this.listaCategoriasChecked = listaCategoriasChecked;
        }

        public enum FormaPagamentoEnum
        {
            Nenhum, CartaoCredito, CartaoDebito, Pix, Dinheiro
        }
        public override void AtualizarInformacoes(Despesa registrosAtualizados)
        {
            this.data = registrosAtualizados.data;
            this.descricao = registrosAtualizados.descricao;
            this.valor = registrosAtualizados.valor;
            this.pagamento = registrosAtualizados.pagamento;
        }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
            {
                listaErros.Add("Campo descrição é obrigatório!");
            }
            else if (valor < 0)
            {
                listaErros.Add("Campo valor é obrigatório!");
            }
            else if (pagamento == FormaPagamentoEnum.Nenhum)
            {
                listaErros.Add("A forma de pagamento é obrigatório!");
            }
            else if(listaCategoriasChecked == null)
            {
                listaErros.Add("A marcação de um categoria é obrigatoria!");
            }

            return listaErros.ToArray();
        }

    }
}
