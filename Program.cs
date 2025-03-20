// See https://aka.ms/new-console-template for more information

class PemrosesData
{
    public float DapatkanNilaiTerbesar<T>(T x1, T x2, T x3)
    {
        dynamic max = x1;
        dynamic max2 = x2;
        dynamic max3 = x3;

        if(max > x2 && max > x3)
        {
            max = x1;
        }
        else if(max2 > x1 && max2 > x3)
        {
            max = x2;
        }
        else
        {
            max = x3;
        }

        return max;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        float x1, x2, x3;
        x1 = Int32.Parse(Console.ReadLine());
        x2 = Int32.Parse(Console.ReadLine());
        x3 = Int32.Parse(Console.ReadLine());

        PemrosesData data = new PemrosesData();
        Console.WriteLine(data.DapatkanNilaiTerbesar(x1, x2, x3));
    }
}
