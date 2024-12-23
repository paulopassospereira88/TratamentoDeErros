
try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());
    int resultado = dividendo / divisor;
    Console.WriteLine($"\n {dividendo} / {divisor} = {resultado}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("\nErro divisao por zero nao permitida");
}
catch (FormatException e)
{
    Console.WriteLine("\nInfome um numero inteiro");
}
catch (OverflowException e)
{
    Console.WriteLine("\nInfome um numero inteiro entre 1 a 99999999");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

