using System.Text.Json;
using System.Text.Json.Serialization;

namespace e_Agenda.Infra.Arquivo.Compartilhado
{
    public abstract class RepositorioArquivoBase<TEntidade> : IRepositorio<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        private Type tipo = typeof(TEntidade);
        string nomeArquivo;
        protected List<TEntidade> listaRegistros;//--> descarregar na lista
        private int contadorRegistros = 0;

        public int Contador
        {
            get
            {
                return contadorRegistros;
            }
        }

        protected List<TEntidade> Desserializador()
        {
            nomeArquivo = $"{tipo.Name}.json";
            JsonSerializerOptions config = ConfigurarLista();

            if (File.Exists(nomeArquivo))
            {
                string conteudo = File.ReadAllText(nomeArquivo);
                return JsonSerializer.Deserialize<List<TEntidade>>(conteudo, config);
            }
            else
            {
                return new List<TEntidade>();
            }
        }

        public virtual void Inserir(TEntidade registro)
        {
            registro.id = contadorRegistros;

            listaRegistros.Add(registro);

            contadorRegistros++;
        }

        public virtual void Editar(int id, TEntidade registroAtualizado)
        {
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Excluir(TEntidade registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);
        }

        public virtual TEntidade SelecionarPorId(int id)
        {

            foreach (TEntidade ent in listaRegistros)
            {
                if (ent.id == id)
                {
                    return ent;
                }
            }

            return null;
        }

        public virtual List<TEntidade> SelecionarTodos()
        {
            return listaRegistros.OrderByDescending(x => x.id).ToList();
        }

        //Serializando por json 

        public void Serializador() 
        {
            nomeArquivo = $"{tipo.Name}.json";

            JsonSerializerOptions config = ConfigurarLista();

            string jsonString = JsonSerializer.Serialize(this.listaRegistros, config);

            File.WriteAllText(nomeArquivo, jsonString);//cria e escreve o arquivo File.WriteAllText(nomeArquivo, objeto);

        }

        private JsonSerializerOptions ConfigurarLista()
        {
            JsonSerializerOptions config = new JsonSerializerOptions();

            config.IncludeFields = true;
            config.WriteIndented = true;
            config.ReferenceHandler = ReferenceHandler.Preserve;

            return config;
        }
    }
}
