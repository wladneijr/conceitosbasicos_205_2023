// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;



//EXERCICIOS COM VETORES
/*
 CRIE UM VETOR PARA ARMAZENAR AS IDADES DE CINCO PESSOAS E AO FINAL IMPRIMA:

1)a passoa mais nova
2)a pessoa mais velha
3)a média das idades
4)todas as idades ímpares
5)todas as idades pares
 
 
 */

byte[] idades = new byte[5];
for (int i = 0; i < 5;i++)
{
    Console.WriteLine($"Informe a {i+1}ª idade");
    idades[i] = byte.Parse(Console.ReadLine());
}

foreach (byte idade in idades);
{
    Console.WriteLine(idade);
}