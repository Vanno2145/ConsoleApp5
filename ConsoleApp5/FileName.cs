using System;

interface IStore
{
    void DisplayInfo(); 
}

class Store : IStore, IDisposable
{
    
    public string Name { get; set; }
    public string Address { get; set; }
    public string StoreType { get; set; }

   
    public Store(string name, string address, string storeType)
    {
        Name = name;
        Address = address;
        StoreType = storeType;
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"Название магазина: {Name}");
        Console.WriteLine($"Адрес магазина: {Address}");
        Console.WriteLine($"Тип магазина: {StoreType}");
    }

    
    public void Dispose()
    {
       
        Console.WriteLine($"Ресурсы магазина '{Name}' освобождены.");
    }
    ~Store()
    {
        Console.WriteLine($"Объект магазина '{Name}' уничтожен.");
    }
}

class Programm
{
    static void Main(string[] args)
    {
        
        using (Store store = new Store("Магазин Одежды", "Москва, ул. Ленина, 1", "Одежда"))
        {
            store.DisplayInfo();
            
        }

      
        Console.WriteLine("Программа завершена.");
        Console.ReadLine();
    }
}
