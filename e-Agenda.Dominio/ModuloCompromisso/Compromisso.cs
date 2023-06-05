using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Dominio.ModuloCompromisso
{
    [Serializable]
    public class Compromisso : EntidadeBase<Compromisso>//Arrumar a parte de editar
    {
        public string assunto { get; set; }
        public DateTime data { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFinal { get; set; }
        public Contato contato { get; set; }
        public string localP { get; set; }
        public string localOn { get; set; }
        public TipoCompromissoEnum tipoComp { get; set; }

        public Compromisso(string assunto, DateTime data, TimeSpan horaInicio, TimeSpan horaFinal, Contato contato, string local, TipoCompromissoEnum tipoComp)
        {
            this.assunto = assunto;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.contato = contato;
            this.tipoComp = tipoComp;

            if (tipoComp == TipoCompromissoEnum.Remoto)
            {
                localOn = local;
            }
            else
            {
                localP = local;
            }

        }

        public Compromisso()
        {
        }

        public override void AtualizarInformacoes(Compromisso registrosAtualizados)
        {
            assunto = registrosAtualizados.assunto;
            data = registrosAtualizados.data;
            horaInicio = registrosAtualizados.horaInicio;
            horaFinal = registrosAtualizados.horaFinal;
            contato = registrosAtualizados.contato;
            tipoComp = registrosAtualizados.tipoComp;

            if (registrosAtualizados.tipoComp == TipoCompromissoEnum.Remoto)
            {
                localOn = registrosAtualizados.localOn;
            }
            else
            {
                localP = registrosAtualizados.localP;
            }
        }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(assunto))
            {
                listaErros.Add("O campo do assunto é obrigatorio!");
            }
            else if (string.IsNullOrEmpty(Convert.ToString(data)))
            {
                listaErros.Add("O campo da data é obrigatorio!");
            }
            else if (string.IsNullOrEmpty(Convert.ToString(horaInicio)))
            {
                listaErros.Add("O campo do horário inicial é obrigatorio!");
            }
            else if (string.IsNullOrEmpty(Convert.ToString(horaFinal)))
            {
                listaErros.Add("O campo do horário final é obrigatorio!");
            }
            else if (string.IsNullOrEmpty(Convert.ToString(tipoComp)))
            {
                listaErros.Add("O campo do tipo de Compromisso é obrigatorio!");
            }

            return listaErros.ToArray();
        }
    }
}
