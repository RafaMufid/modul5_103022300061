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
class SimpleDataBase<T>
{
    List<T> storedData;
    List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]} yang disimpan pada waktu UTC: {inputDates[i]}");
        }
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

        SimpleDataBase<float> dataBase = new SimpleDataBase<float>();

        dataBase.AddNewData(10);
        dataBase.AddNewData(30);
        dataBase.AddNewData(22);

        dataBase.PrintAllData();
    }
}
