using System;

class Play
{
    
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    
    public Play(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Жанр: {Genre}");
        Console.WriteLine($"Год выпуска: {Year}");
    }

    
    ~Play()
    {
       
        Console.WriteLine($"Объект пьесы '{Title}' уничтожен.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Play play = new Play("Гамлет", "Шекспир", "Трагедия", 1609);

        
        play.DisplayInfo();

        
        Console.ReadLine();
    }
}
