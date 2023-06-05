namespace e_Agenda.Dominio.ModuloCategoriaDespesa
{
    public class CategoriaDespesa : EntidadeBase<CategoriaDespesa>
    {
        public string titulo { get; set; }

        public CategoriaDespesa(string titulo)
        {
            this.titulo = titulo;
        }

        public CategoriaDespesa()
        {
            
        }

        public override void AtualizarInformacoes(CategoriaDespesa registrosAtualizados)
        {
            this.titulo = registrosAtualizados.titulo;
        }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
            {
                listaErros.Add("Digite o titulo da Categoria");
            }

            return listaErros.ToArray();
        }

        public override string ToString()
        {
            return $"ID: {id} - {titulo}";
        }

    }
}
