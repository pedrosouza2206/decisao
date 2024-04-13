﻿int numero;

Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if(numero >= 0)
{ 
    Console.ForegroundColor = ConsoleColor.Green; 
}
else 
{
      Console.ForegroundColor = ConsoleColor.Red;
}
Console.WriteLine($"o número digitado é {numero}.");

Console.ResetColor();
