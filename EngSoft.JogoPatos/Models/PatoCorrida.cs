namespace EngSoft.JogoPatos.Models
{
    public class PatoCorrida : Pato
    {
        public PatoCorrida()
        {
            SetComportamentoCorrida(new Corredor());
        }

        public override string Mostrar()
        {
            return "Eu sou o pato que corre";
        }
    }
}
