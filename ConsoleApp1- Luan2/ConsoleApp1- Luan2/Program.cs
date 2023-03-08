// See https://aka.ms/new-console-template for more information
using ConsoleApp1__Luan2;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "Mouse sem fio", 59.90M);
Console.WriteLine(p1.getDescricao()+ " " +p1.getValor() );