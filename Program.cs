class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program
{
    static void Main()
    {
        DataGeneric<string> dataNIM = new DataGeneric<string>("103022300114");
        dataNIM.PrintData();
      
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Aryo");
    }
}