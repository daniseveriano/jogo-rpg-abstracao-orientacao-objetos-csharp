// See https://aka.ms/new-console-template for more information
using jogo_rpg_abstracao_orientacao_objetos_csharp.src.Entities;

Knight arus = new Knight("Arus", 23, "Knight");
Wizard wizard = new Wizard("Jennica", 40, "White Wizard");

Console.WriteLine(arus);
Console.WriteLine(wizard);
Console.WriteLine(arus.Attack());
Console.WriteLine(wizard.Attack(1));
Console.WriteLine(wizard.Attack(7));
