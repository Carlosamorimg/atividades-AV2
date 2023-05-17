using System;

class terceira

//3 - Crie uma array com 8 itens.Imprima na tela os elementos dessa array .

{
    static void Main(String[] args)


    {
        Console.WriteLine("Digite sua lista de compras: ");

        string [] lista = new string [8];
        for (int i = 0; i < 8; i++)
        {
           lista [i]=  Console.ReadLine();
        }
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Sua lista de compras é: ");

        foreach (string s in lista)
        {
            Console.WriteLine (s);
        }


    }
}
