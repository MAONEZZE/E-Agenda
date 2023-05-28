using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase<Compromisso>//Arrumar a parte de editar
    {
        public string assunto;
        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaFinal;
        public Contato contato;
        public string localP;
        public string localOn;
        public TipoCompromissoEnum tipoComp;

        public Compromisso(string assunto, DateTime data, TimeSpan horaInicio, TimeSpan horaFinal, Contato contato, string local, TipoCompromissoEnum tipoComp)
        {
            this.assunto = assunto;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.contato = contato;
            this.tipoComp = tipoComp;

            if(tipoComp == TipoCompromissoEnum.Remoto)
            {
                this.localOn = local;
            }
            else
            {
                this.localP = local;
            }
            
        }

        public override void AtualizarInformacoes(Compromisso registrosAtualizados)
        {
            this.assunto = registrosAtualizados.assunto;
            this.data = registrosAtualizados.data;
            this.horaInicio = registrosAtualizados.horaInicio;
            this.horaFinal = registrosAtualizados.horaFinal;
            this.contato = registrosAtualizados.contato;
            this.tipoComp = registrosAtualizados.tipoComp;

            if (registrosAtualizados.tipoComp == TipoCompromissoEnum.Remoto)
            {
                this.localOn = registrosAtualizados.localOn;
            }
            else
            {
                this.localP = registrosAtualizados.localP;
            }
        }

        public override string ToString()
        {
            return $"ID: {id} - Assunto: {assunto} | Data: {data} | Inicio: {horaInicio}";
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
