using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public class VoarFoguete : PadraoVoaveis
    {
        public double Velocidade { get; private set; }

        public VoarFoguete()
        {
            Velocidade = 1000;
        }

        public double GetVelocidade()
        {
            return Velocidade;
        }

        public string Voar()
        {
            return $"Voando como um foguete. Velocidade: {Velocidade}";
        }
    }
}
