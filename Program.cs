// See https://aka.ms/new-console-template for more information

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
            Console.WriteLine($"Data {i+1} berisi: {storedData[i]} yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<float> dataBase = new SimpleDataBase<float>();

        dataBase.AddNewData(10);
        dataBase.AddNewData(30);
        dataBase.AddNewData(22);

        dataBase.PrintAllData();
    }
}
