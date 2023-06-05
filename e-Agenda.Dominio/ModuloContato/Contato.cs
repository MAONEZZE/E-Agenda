namespace e_Agenda.Dominio.ModuloContato
{

    [Serializable]
    public class Contato : EntidadeBase<Contato>
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string cargo { get; set; }
        public string empresa { get; set; }

        public Contato(string nome, string telefone, string email, string cargo, string empresa)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo; 
            this.empresa = empresa;
        }

        public Contato()
        {
        }

        public override void AtualizarInformacoes(Contato registrosAtualizados)
        {
            this.nome = registrosAtualizados.nome;
            this.telefone = registrosAtualizados.telefone;
            this.email = registrosAtualizados.email;
            this.cargo = registrosAtualizados.cargo;
            this.empresa = registrosAtualizados.empresa;
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

        //public override JsonObject CarregarJSON()
        //{
        //    JsonObject json = new JsonObject();

        //    json.Add("Nome", nome);
        //    json.Add("telefone", telefone);
        //    json.Add("email", email);
        //    json.Add("cargo", cargo);
        //    json.Add("empresa", empresa);

        //    return json;
        //}
    }
}
