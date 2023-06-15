public class Impostos
{
    public double valor;
    public double pisss;
    public double icmss;
    public double confinss;
    public double lucroo;
    public string unidadee;
    public double CalcularImpostos()
    {
        double calcularpis = (valor * pisss) / 100;
        double calcularicms = (valor * icmss) / 100;
        double calcularconfins = (valor * confinss) / 100;
        double somaI = calcularpis + calcularicms + calcularconfins;
        double calcularlucro = (valor * lucroo) / 100;
        if (unidadee == "LT")
        {
            double lt = (valor * 5) / 100;
            return somaI + calcularlucro + valor + lt;
        }
        else if (unidadee == "KL")
        {
            double kl = (valor * 5) / 100;
            return somaI + calcularlucro + valor + kl;
        }

        else
        {
            double valorVenda = somaI + calcularlucro + valor;
            return valorVenda;
        }
        
    }
}
