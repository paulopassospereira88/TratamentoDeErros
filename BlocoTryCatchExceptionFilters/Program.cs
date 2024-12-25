try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());
    int resultado = dividendo / divisor;
    Console.WriteLine($"\n {dividendo} / {divisor} = {resultado}");
}
catch (DivideByZeroException ex) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
{
    Console.WriteLine("\nHoje e sexta feira e nao capturamos estas excecoes por motivos obvios... \n\nSextouuuu\n\n");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine(ex.StackTrace);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}