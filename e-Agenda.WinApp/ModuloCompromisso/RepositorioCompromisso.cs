using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {

        public RepositorioCompromisso(List<Compromisso> listaCompromisso)
        {
            this.listaRegistros = listaCompromisso;
        }

        public List<Compromisso> SelecionarCompPassados(DateTime dataAgora)
        {
            List<Compromisso> listaCompPassados = new List<Compromisso>();

            foreach(Compromisso comp in listaRegistros)
            {
                if(comp.data < dataAgora)
                {
                    listaCompPassados.Add(comp);
                }
            }

            return listaCompPassados;

            // ou assim return listaRegistros.Where(x => x.data < dataAgora).ToList();
        }

        public List<Compromisso> SelecionarCompFuturos(DateTime dataInicio, DateTime dataFim)
        {
            List<Compromisso> listaCompFuturos = new List<Compromisso>();

            foreach (Compromisso comp in listaRegistros)
            {
                if (comp.data > dataInicio && comp.data < dataFim)
                {
                    listaCompFuturos.Add(comp);
                }
            }

            return listaCompFuturos;

            // ou assim return listaRegistros.Where(x => x.data > dataAgora).ToList();
        }
    }
}
