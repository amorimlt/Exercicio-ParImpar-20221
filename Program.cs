int Numerodigitado;

Console.Write("\nDigite um número: ");
Numerodigitado = Convert.ToInt32 (Console.ReadLine());

bool NumeroEhPar = (Numerodigitado % 2) == 0;

if (NumeroEhPar)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine ("Esse número é par, divisível por 2\n");
    Console.ResetColor();

}

else 
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine ("Esse número é ímpar, não divisível por 2\n");
    Console.ResetColor();
}

//Console.ResetColor();