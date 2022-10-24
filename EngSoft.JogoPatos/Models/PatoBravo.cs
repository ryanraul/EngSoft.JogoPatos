using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public class PatoBravo : Pato, PadraoGrasnar
    {
        public PatoBravo()
        {
            SetComportamentoCorrida(new Maratonista());
        }
        public string Grasnar()
        {
            return "Que-Que. Grrrrrrrrr.";
        }

        public override string Mostrar()
        {
            return "Eu sou o Pato Bravo.";
        }
    }
}
