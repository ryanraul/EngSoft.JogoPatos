using EngSoft.JogoPatos.Models;

Pato pt = new PatoRuivo();
Console.WriteLine(pt.Mostrar());
Console.WriteLine(pt.Nadar());
Console.WriteLine(pt.GetComportamentoVooPato());
pt.SetComportamentoVoo(new VoarFoguete());
Console.WriteLine(pt.GetComportamentoVooPato());

// Implementação do pato corredor e maratonista

Pato patoCorrida = new PatoCorrida();
Console.WriteLine(patoCorrida.Mostrar());
Console.WriteLine(patoCorrida.GetComportamentoCorridaPato());

patoCorrida.SetComportamentoCorrida(new Maratonista());
Console.WriteLine(patoCorrida.GetComportamentoCorridaPato());

patoCorrida.SetDistanciaComportamentoCorrerPato(300);
Console.WriteLine(patoCorrida.GetComportamentoCorridaPato());

