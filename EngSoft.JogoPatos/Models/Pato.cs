using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public abstract class Pato
    {
        protected PadraoVoaveis ComportamentoVooPato;

        protected PadraoCorrer ComportamentoCorridaPato;
        public abstract string Mostrar();

        public string Nadar()
        {
            return "Pato Nadando.";
        }

        public void SetComportamentoVoo(PadraoVoaveis padrao)
        {
            ComportamentoVooPato = padrao;
        }

        public string GetComportamentoVooPato()
        {
            return ComportamentoVooPato.Voar();
        }

        public void SetComportamentoCorrida(PadraoCorrer padrao)
        {
            ComportamentoCorridaPato = padrao;
        }

        public string GetComportamentoCorridaPato()
        {
            return ComportamentoCorridaPato.Correr();
        }

        public void SetDistanciaComportamentoCorrerPato(int distancia)
        {
            if(ComportamentoCorridaPato != null)
                ComportamentoCorridaPato.SetDistancia(distancia);
        }

    }
}
