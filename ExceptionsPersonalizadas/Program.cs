using ExceptionsPersonalizadas;

Conta conta1 = new Conta(100, "Maria", 100.0);

try
{
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(100);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
    conta1.Sacar(300);
    Console.WriteLine($"Saldo : {conta1.Saldo}");

}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.HelpLink);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

class Conta
{
    private int numero;
    private string? titular;
    private double saldo;

    public Conta(int numero, string? titular, double saldo)
    {
        this.Numero = numero;
        this.Titular = titular;
        this.Saldo = saldo;
    }

    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }

    public string? Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public double Saldo
    {
        get { return saldo; }
        private set { saldo = value; }
    }

    public double Depositar(double valor)
    {
        saldo += valor;
        Console.WriteLine($"Depositou : {valor}");
        return saldo;
    }

    public double Sacar(double valor)
    {
        Console.WriteLine($"Sacou : {valor}");
        if (saldo < valor)
        {
            throw new SaldoInsuficienteException(valor, Saldo);
        }

        saldo += valor;
        return saldo;
    }

    public override string ToString()
    {
        return $"Conta: {numero}, Titular: {titular}, Saldo: {saldo}";
    }

}
