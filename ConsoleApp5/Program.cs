using System;
using System.Collections;

class Employee
{
    public string FullName { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public string Email { get; set; }

    public override string ToString() =>
        $"ФИО: {FullName}, Должность: {Position}, Зарплата: {Salary} руб., Email: {Email}";
}
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public override string ToString() =>
        $"Название: {Title}, Автор: {Author}, Жанр: {Genre}, Год выпуска: {Year}";
}

class Program
{
    static void Main()
    {
        LinkedList<Book> books = new LinkedList<Book>();

        while (true)
        {
            Console.WriteLine("\n1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Изменить информацию о книге");
            Console.WriteLine("4. Найти книгу");
            Console.WriteLine("5. Вставить книгу в начало");
            Console.WriteLine("6. Вставить книгу в конец");
            Console.WriteLine("7. Вставить книгу в определенную позицию");
            Console.WriteLine("8. Удалить книгу из начала");
            Console.WriteLine("9. Удалить книгу из конца");
            Console.WriteLine("10. Удалить книгу из определенной позиции");
            Console.WriteLine("11. Показать все книги");
            Console.WriteLine("12. Выход");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            if (choice == "1") AddBook(books);
            else if (choice == "2") RemoveBook(books);
            else if (choice == "3") UpdateBook(books);
            else if (choice == "4") SearchBook(books);
            else if (choice == "5") InsertBookAtStart(books);
            else if (choice == "6") InsertBookAtEnd(books);
            else if (choice == "7") InsertBookAtPosition(books);
            else if (choice == "8") RemoveBookFromStart(books);
            else if (choice == "9") RemoveBookFromEnd(books);
            else if (choice == "10") RemoveBookAtPosition(books);
            else if (choice == "11") ShowAllBooks(books);
            else if (choice == "12") break;
            else Console.WriteLine("Неверный выбор, попробуйте снова.");
        }
        List<Employee> employees = new List<Employee>();
        while (true)
        {
            Console.WriteLine("\n1. Добавить 2. Удалить 3. Изменить 4. Найти 5. Сортировать 6. Показать 7. Выход");
            string choice = Console.ReadLine();

            if (choice == "1") AddEmployee(employees);
            else if (choice == "2") RemoveEmployee(employees);
            else if (choice == "3") UpdateEmployee(employees);
            else if (choice == "4") SearchEmployee(employees);
            else if (choice == "5") SortEmployees(employees);
            else if (choice == "6") employees.ForEach(Console.WriteLine);
            else if (choice == "7") break;
            else Console.WriteLine("Неверный ввод.");
        }
    }
    static void AddBook(LinkedList<Book> books)
    {
        Console.Write("Введите название книги: ");
        string title = Console.ReadLine();
        Console.Write("Введите ФИО автора: ");
        string author = Console.ReadLine();
        Console.Write("Введите жанр книги: ");
        string genre = Console.ReadLine();
        Console.Write("Введите год выпуска: ");
        int year = int.Parse(Console.ReadLine());

        books.AddLast(new Book { Title = title, Author = author, Genre = genre, Year = year });
        Console.WriteLine("Книга добавлена.");
    }

   
    static void RemoveBook(LinkedList<Book> books)
    {
        Console.Write("Введите название книги для удаления: ");
        string title = Console.ReadLine();

        var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Книга удалена.");
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }

    
    static void UpdateBook(LinkedList<Book> books)
    {
        Console.Write("Введите название книги для изменения: ");
        string title = Console.ReadLine();

        var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            Console.Write("Введите новый жанр (или Enter для пропуска): ");
            string genre = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(genre)) book.Genre = genre;

            Console.Write("Введите новый год выпуска (или Enter для пропуска): ");
            string yearInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(yearInput)) book.Year = int.Parse(yearInput);

            Console.WriteLine("Информация о книге обновлена.");
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }

    
    static void SearchBook(LinkedList<Book> books)
    {
        Console.Write("Введите параметр для поиска (Название/Автор/Жанр): ");
        string query = Console.ReadLine();

        var results = books.Where(b =>
            b.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
            b.Author.Contains(query, StringComparison.OrdinalIgnoreCase) ||
            b.Genre.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();

        if (results.Any())
        {
            Console.WriteLine("Найденные книги:");
            results.ForEach(Console.WriteLine);
        }
        else
        {
            Console.WriteLine("Книги не найдены.");
        }
    }

    
    static void InsertBookAtStart(LinkedList<Book> books)
    {
        Console.Write("Введите название книги: ");
        string title = Console.ReadLine();
        Console.Write("Введите ФИО автора: ");
        string author = Console.ReadLine();
        Console.Write("Введите жанр книги: ");
        string genre = Console.ReadLine();
        Console.Write("Введите год выпуска: ");
        int year = int.Parse(Console.ReadLine());

        books.AddFirst(new Book { Title = title, Author = author, Genre = genre, Year = year });
        Console.WriteLine("Книга вставлена в начало списка.");
    }

    
    static void InsertBookAtEnd(LinkedList<Book> books)
    {
        Console.Write("Введите название книги: ");
        string title = Console.ReadLine();
        Console.Write("Введите ФИО автора: ");
        string author = Console.ReadLine();
        Console.Write("Введите жанр книги: ");
        string genre = Console.ReadLine();
        Console.Write("Введите год выпуска: ");
        int year = int.Parse(Console.ReadLine());

        books.AddLast(new Book { Title = title, Author = author, Genre = genre, Year = year });
        Console.WriteLine("Книга вставлена в конец списка.");
    }

    
    static void InsertBookAtPosition(LinkedList<Book> books)
    {
        Console.Write("Введите индекс для вставки (начиная с 0): ");
        int index = int.Parse(Console.ReadLine());

        if (index < 0 || index > books.Count)
        {
            Console.WriteLine("Неверный индекс.");
            return;
        }

        Console.Write("Введите название книги: ");
        string title = Console.ReadLine();
        Console.Write("Введите ФИО автора: ");
        string author = Console.ReadLine();
        Console.Write("Введите жанр книги: ");
        string genre = Console.ReadLine();
        Console.Write("Введите год выпуска: ");
        int year = int.Parse(Console.ReadLine());

        var newBook = new Book { Title = title, Author = author, Genre = genre, Year = year };
        var node = books.First;

        for (int i = 0; i < index; i++)
        {
            node = node.Next;
        }

        books.AddAfter(node, newBook);
        Console.WriteLine("Книга вставлена в указанную позицию.");
    }

    
    static void RemoveBookFromStart(LinkedList<Book> books)
    {
        if (books.Any())
        {
            books.RemoveFirst();
            Console.WriteLine("Первая книга удалена.");
        }
        else
        {
            Console.WriteLine("Список книг пуст.");
        }
    }

    
    static void RemoveBookFromEnd(LinkedList<Book> books)
    {
        if (books.Any())
        {
            books.RemoveLast();
            Console.WriteLine("Последняя книга удалена.");
        }
        else
        {
            Console.WriteLine("Список книг пуст.");
        }
    }

    
    static void RemoveBookAtPosition(LinkedList<Book> books)
    {
        Console.Write("Введите индекс книги для удаления (начиная с 0): ");
        int index = int.Parse(Console.ReadLine());

        if (index < 0 || index >= books.Count)
        {
            Console.WriteLine("Неверный индекс.");
            return;
        }

        var node = books.First;
        for (int i = 0; i < index; i++)
        {
            node = node.Next;
        }

        books.Remove(node);
        Console.WriteLine("Книга удалена.");
    }

    
    static void ShowAllBooks(LinkedList<Book> books)
    {
        if (books.Any())
        {
            Console.WriteLine("Все книги:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
        else
        {
            Console.WriteLine("Нет книг в списке.");
        }
    }

    static void AddEmployee(List<Employee> employees)
    {
        Console.Write("ФИО: "); string name = Console.ReadLine();
        Console.Write("Должность: "); string position = Console.ReadLine();
        Console.Write("Зарплата: "); decimal salary = decimal.Parse(Console.ReadLine());
        Console.Write("Email: "); string email = Console.ReadLine();

        employees.Add(new Employee { FullName = name, Position = position, Salary = salary, Email = email });
    }

    static void RemoveEmployee(List<Employee> employees)
    {
        Console.Write("Введите ФИО для удаления: ");
        string name = Console.ReadLine();
        var employee = employees.FirstOrDefault(e => e.FullName == name);
        if (employee != null)
        {
            employees.Remove(employee);
            Console.WriteLine("Сотрудник удалён.");
        }
        else
        {
            Console.WriteLine("Сотрудник не найден.");
        }
    }

    static void UpdateEmployee(List<Employee> employees)
    {
        Console.Write("Введите ФИО для изменения: ");
        string name = Console.ReadLine();
        var employee = employees.FirstOrDefault(e => e.FullName == name);
        if (employee != null)
        {
            Console.Write("Новая должность: "); employee.Position = Console.ReadLine();
            Console.Write("Новая зарплата: "); employee.Salary = decimal.Parse(Console.ReadLine());
            Console.Write("Новый email: "); employee.Email = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Сотрудник не найден.");
        }
    }

    static void SearchEmployee(List<Employee> employees)
    {
        Console.Write("Введите параметр для поиска: ");
        string query = Console.ReadLine();
        var results = employees.Where(e => e.FullName.Contains(query) || e.Position.Contains(query) || e.Email.Contains(query)).ToList();
        if (results.Any())
        {
            Console.WriteLine("Найденные сотрудники:");
            results.ForEach(Console.WriteLine);
        }
        else
        {
            Console.WriteLine("Сотрудники не найдены.");
        }
    }

    static void SortEmployees(List<Employee> employees)
    {
        Console.WriteLine("Выберите параметр для сортировки:");
        Console.WriteLine("1. По ФИО 2. По должности 3. По зарплате 4. По email");
        string choice = Console.ReadLine();

        if (choice == "1") employees = employees.OrderBy(e => e.FullName).ToList();
        else if (choice == "2") employees = employees.OrderBy(e => e.Position).ToList();
        else if (choice == "3") employees = employees.OrderBy(e => e.Salary).ToList();
        else if (choice == "4") employees = employees.OrderBy(e => e.Email).ToList();

        Console.WriteLine("Сотрудники отсортированы.");
        employees.ForEach(Console.WriteLine);
    }