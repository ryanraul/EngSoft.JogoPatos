using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public class Maratonista : PadraoCorrer
    {
        public double Velocidade { get; private set; }
        public int Distancia { get; private set; }

        public Maratonista()
        {
            Distancia = 200;
            SetVelocidade();
        }

        private void SetVelocidade()
        {
            Velocidade = Distancia <= 200 ? 20 : 10;
        }

        public string Correr()
        {
            return $"Maratonista. Velocidade: {Velocidade} m/s";
        }

        public void SetDistancia(int distancia)
        {
            Distancia = distancia;
            SetVelocidade();
        }
    }
}
