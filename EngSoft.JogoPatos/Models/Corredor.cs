using EngSoft.JogoPatos.Interfaces;

namespace EngSoft.JogoPatos.Models
{
    public class Corredor : PadraoCorrer
    {
        public double Velocidade { get; private set; }
        public int Distancia { get; private set; }

        public Corredor()
        {
            Velocidade = 10;
        }

        public string Correr()
        {
            return $"Corredor. Velocidade: {Velocidade} m/s";
        }

        public void SetDistancia(int distancia)
        {
            Distancia = distancia;
        }
    }
}
