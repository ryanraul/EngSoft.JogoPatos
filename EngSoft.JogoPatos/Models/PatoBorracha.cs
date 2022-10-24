namespace EngSoft.JogoPatos.Models
{
    public class PatoBorracha : Pato
    {
        public PatoBorracha()
        {
            SetComportamentoVoo(new NaoVoa());
        }

        public override string Mostrar()
        {
           return "Olá, eu sou de Borracha.";
        }
    }
}
