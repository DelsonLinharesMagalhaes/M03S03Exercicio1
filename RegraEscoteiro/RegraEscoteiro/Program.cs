// Limpando informações desnecessárias
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Valor percentual: " + CalculaValorPercentual(120, 20));
    }


    // Nome da função mais entendivel
    // Nome das variáveis mais entendiveis
    public static double CalculaValorPercentual(double pValorBase, double pPercentual)
    {
        // Refatorando, diminuindo o código
        return pValorBase * (pPercentual / 100);
    }

}