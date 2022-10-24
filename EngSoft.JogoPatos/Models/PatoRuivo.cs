using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public class PatoRuivo : Pato, PadraoGrasnar
    {
        public PatoRuivo()
        {
            SetComportamentoVoo(new VoaveisAsa());
            SetComportamentoCorrida(new Corredor());
        }

        public string Grasnar()
        {
            return "Que-Que";
        }

        public override string Mostrar()
        {
            return "Eu sou o Pato Ruivo.";
        }
    }
}
