using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public class PatoRuivo : Pato, PadraoGrasnar
    {
        public PatoRuivo()
        {
            SetComportamento(new VoaveisAsa());
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
