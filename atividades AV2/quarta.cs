using System;

class quarta

//4 - Crie uma array de 5 itens que serão cadastrados pelos usuários.
//Traga a média de todos os itens.


{
    static void Main(String[] args)


    {
        Console.WriteLine("Digite suas 5 notas para saber se você foi aprovado: ");
        double media = 0;

        double [] notas = new double [5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($" Digite a  nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < notas.Length; i++)
        {
             media += notas[i];
        }
        Console.WriteLine("Sua media é: " + media/notas.Length);
    }
}
