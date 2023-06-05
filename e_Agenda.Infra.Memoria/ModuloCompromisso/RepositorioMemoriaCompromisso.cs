using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.Infra.Memoria.ModuloCompromisso
{
    public class RepositorioMemoriaCompromisso : RepositorioMemoriaBase<Compromisso>
    {
        public RepositorioMemoriaCompromisso(List<Compromisso> listaCompromissos)
        {
            this.listaRegistros = listaCompromissos;
        }

        public List<Compromisso> SelecionarCompPassados(DateTime dataAgora)
        {
            List<Compromisso> listaCompPassados = new List<Compromisso>();

            foreach (Compromisso comp in listaRegistros)
            {
                if (comp.data < dataAgora)
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
