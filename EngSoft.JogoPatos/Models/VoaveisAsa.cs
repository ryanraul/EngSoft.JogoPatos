using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public class VoaveisAsa : PadraoVoaveis
    {
        public double Velocidade { get; private set; }

        public VoaveisAsa()
        {
            Velocidade = 10;
        }

        public double GetVelocidade()
        {
            return Velocidade;
        }

        public string Voar()
        {
            return $"Voando como um pássaro que voa. Velocidade: {Velocidade}";
        }
    }
}
