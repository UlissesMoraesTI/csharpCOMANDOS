
using System.Data.Common;

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);

dataAtual = DateTime.Now;
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

dataAtual = DateTime.Now;
Console.WriteLine(dataAtual.ToString("HH:mm:ss"));

dataAtual = DateTime.Now;
Console.WriteLine(dataAtual.ToString("HH:mm"));
