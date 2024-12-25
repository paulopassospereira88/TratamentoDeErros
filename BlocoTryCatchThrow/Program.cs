try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception)
        {
            throw;
            Console.WriteLine("Tratando o erro em A");
        }
        
    }
}

class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception)
        {
            throw;
            Console.WriteLine("Tratando o erro em B");
        }
    }
}

class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Metodo nao implmentando");
    }
}