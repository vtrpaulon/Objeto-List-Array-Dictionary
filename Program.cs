using System;
using System.Collections.Generic;

class Program
{

    public static void Main(string[] args)
    {
        //Objeto classe pessoa
        Pessoa pessoa1 = new Pessoa("Vitor", 37);


        Console.WriteLine(pessoa1.Nome);
        Console.WriteLine(pessoa1.Idade);
        
        //Lista de Pessoas
        List <string> list = new List <string> ();

        list.Add("Vitor");
        list.Add("Fernanda");
        list.Add("Tito");

        list.Remove("Tito");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        //Array de Pessoas
        string[] Nomes = new string[3];
        Nomes[0] = "Um";
        Nomes[1] = "Dois";
        Nomes[2] = "Tres";

        foreach (var item in Nomes)
        {
            Console.WriteLine(item);
        }

        //Dictionary onde a chave é do tipo string e o valor é do tipo int
        Dictionary<string, int> idadeDasPessoas = new Dictionary<string, int>();

        // Adicionando pares chave-valor ao Dictionary
        idadeDasPessoas.Add("Vitor", 37);
        idadeDasPessoas.Add("Fernanda", 38);
        idadeDasPessoas.Add("Tito", 15);

        // Acessando os valores usando a chave
        Console.WriteLine("Idade do Vitor: " + idadeDasPessoas["Vitor"]);
        Console.WriteLine("Idade da Fernanda: " + idadeDasPessoas["Fernanda"]);
        Console.WriteLine("Idade do Tito: " + idadeDasPessoas["Tito"]);

        // Iterando sobre os pares chave-valor no Dictionary
        Console.WriteLine("\nListando todas as idades:");
        foreach (var item in idadeDasPessoas)
        {
            Console.WriteLine($"Nome: {item.Key}, Idade: {item.Value}");
        }

        Console.ReadLine();
    }    
}