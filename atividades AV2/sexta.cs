using System;

class sexta

//6 - O usuário entrará com 10 nomes de carros. Após isso, o usuário digitará um carro e o sistema informará se é
//um dos carros q ele mesmo cadastrado.

{
    static void Main(String[] args)
    {

        Console.WriteLine("Cadastre o modelo dos 10 carros que estão na feira: ");

        string[] carros = new string[10];
        

        for (int i = 0; i < carros.Length; i++)
        {
            Console.WriteLine($" Digite  {i + 1} carros: ");
            carros[i] = Console.ReadLine();

        }
         Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Digite o modelo de um carro para buscar: ");
        string mod =Console.ReadLine();

       foreach (string s in carros)
        {
            if (s == mod)
            {
                
                Console.WriteLine("Você ja cadastrou esse carro " );
                break;
            }
           
           

        }
        Console.WriteLine("Carro não cadastrado!!!");

    }
}
