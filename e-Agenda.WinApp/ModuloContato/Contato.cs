using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase<Contato>
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email;
        public string cargo;
        public string empresa;

        public Contato(string nome, string telefone, string email, string cargo, string empresa)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo; 
            this.empresa = empresa;
        }

        public override void AtualizarInformacoes(Contato registrosAtualizados)
        {
            this.nome = registrosAtualizados.nome;
            this.telefone = registrosAtualizados.telefone;
            this.email = registrosAtualizados.email;
            this.cargo = registrosAtualizados.cargo;
            this.empresa = registrosAtualizados.empresa;
        }

        public override string ToString()
        {
            return $"Id: {id} - {nome} | Telefone: {telefone} | Empresa: {empresa}";
        }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(nome))
            {
                listaErros.Add("O campo do nome é obrigatorio!");
            }
            else if (string.IsNullOrEmpty(cargo))
            {
                listaErros.Add("O campo do cargo é obrigatorio!");
            }
            else if (string.IsNullOrEmpty(empresa))
            {
                listaErros.Add("O campo do empresa é obrigatorio!");
            }
            else if (string.IsNullOrEmpty(telefone))
            {
                listaErros.Add("O campo do telefone é obrigatorio!");
            }
            else if (string.IsNullOrEmpty(email))
            {
                listaErros.Add("O campo do e-mail é obrigatorio!");
            }

            return listaErros.ToArray();
        }
    }
}
