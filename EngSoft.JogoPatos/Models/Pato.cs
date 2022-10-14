using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public abstract class Pato
    {
        protected PadraoVoaveis ComportamentoPato;
        public abstract string Mostrar();

        public string Nadar()
        {
            return "Pato Nadando.";
        }

        public void SetComportamento(PadraoVoaveis padrao)
        {
            ComportamentoPato = padrao;
        }

        public string GetComportamentoPato()
        {
            return ComportamentoPato.Voar();
        }

    }
}
