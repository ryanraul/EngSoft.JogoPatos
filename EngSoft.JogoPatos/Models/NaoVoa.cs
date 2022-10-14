using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public class NaoVoa : PadraoVoaveis
    {
        public double GetVelocidade()
        {
            return 0;
        }

        public string Voar()
        {
            return "Esse pato não Voa. Velocidade" + GetVelocidade();
        }
    }
}
