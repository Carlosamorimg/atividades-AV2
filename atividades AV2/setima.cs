using System;

class setima

    //7 - Crie um sistema que receba um sinal (+,-, * ou /)... Se ele escolher dividir você multiplica, e vice e versa.
    //Se ele escolher subtração você soma, e vice versa.

{

    static int soma(int num1, int num2)
    {
        return num1 - num2;
    }
    static int sub(int num1, int num2)
    {
        return num1 + num2;
    }
    static int mult(int num1, int num2)
    {
        return num1 / num2;
    }
    static int div(int num1, int num2)
    {
        return num1 * num2;
    }

    static void Main(String[] args)


    {
        Console.WriteLine("Digite a Operação que deseja usando os simbolos: ex +, -, *, / ");
        string sinal =Console.ReadLine();

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Você escolheu:  " + sinal);

        Console.WriteLine("Digite um Numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro Numero: ");
        int num2 = int.Parse(Console.ReadLine());

        if (sinal == "+")
        {
            Console.WriteLine(soma(num1,num2));
            Console.WriteLine("opss algo não esta certo!!!!");
            Console.ReadKey();
        }
        if (sinal == "-")
        {
            Console.WriteLine(sub(num1, num2));
            Console.WriteLine("opss algo não esta certo!!!!");
            Console.ReadKey();
        }
        if (sinal == "*")
        {
            Console.WriteLine(mult(num1, num2));
            Console.WriteLine("opss algo não esta certo!!!!");
            Console.ReadKey();
        }
        if (sinal == "/")
        {
            Console.WriteLine(div(num1, num2));
            Console.WriteLine("opss algo não esta certo!!!!");
            Console.ReadKey();
        }
       
    }
}
