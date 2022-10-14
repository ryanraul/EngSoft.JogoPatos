using EngSoft.JogoPatos.Models;

Console.WriteLine("Hello, World!");

Pato pt = new PatoRuivo();

Console.WriteLine(pt.Mostrar());
Console.WriteLine(pt.Nadar());
Console.WriteLine(pt.GetComportamentoPato());

pt.SetComportamento(new VoarFoguete());

Console.WriteLine(pt.GetComportamentoPato());