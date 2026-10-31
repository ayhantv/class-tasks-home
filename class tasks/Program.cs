using class_tasks;

AppDbcontext context = new();

Employee[] workers = context.GetAllWorkers();

// 1. Iscilerin yaslarinin cemi
int GetWorkersAgeSum()
{
    int sum = 0;

    foreach (var item in workers)
    {
        sum += item.Age;
    }

    return sum;
}

// 2. Iscilerin yaslari
int[] GetWorkersAges()
{
    int[] ages = new int[workers.Length];

    for (int i = 0; i < workers.Length; i++)
    {
        ages[i] = workers[i].Age;
    }

    return ages;
}

// 3. Iscilerin yas ortalamasi
double GetWorkersAgeAverage()
{
    int sum = 0;

    foreach (var item in workers)
    {
        sum += item.Age;
    }

    return (double)sum / workers.Length;
}

// 4. FullName-e gore isci axtarmaq
Employee? GetWorkerByFullName(string fullName)
{
    foreach (var item in workers)
    {
        if (item.FullName == fullName)
        {
            return item;
        }
    }

    return null;
}

// 5. Iscilerin maas ortalamasi
double GetWorkersSalaryAverage()
{
    double sum = 0;

    foreach (var item in workers)
    {
        sum += item.salary;
    }

    return sum / workers.Length;
}

// Metodlarin cagirilmasi

Console.WriteLine("1. Iscilerin yaslarinin cemi:");
Console.WriteLine(GetWorkersAgeSum());

Console.WriteLine("2. Iscilerin yaslari:");
Console.WriteLine(string.Join(", ", GetWorkersAges()));

Console.WriteLine("3. Iscilerin yas ortalamasi:");
Console.WriteLine(GetWorkersAgeAverage());

Console.WriteLine("4. Isci axtarisi");
Console.WriteLine("FullName daxil edin:");

string name = Console.ReadLine()!;

Employee? worker = GetWorkerByFullName(name);

if (worker != null)
{
    Console.WriteLine($"FullName: {worker.FullName}");
    Console.WriteLine($"Email: {worker.Email}");
    Console.WriteLine($"Age: {worker.Age}");
}
else
{
    Console.WriteLine("Isci tapilmadi!");
}

Console.WriteLine("5. Iscilerin maas ortalamasi:");
Console.WriteLine(GetWorkersSalaryAverage());
