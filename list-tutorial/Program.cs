// WorkWithStrings();
Generate20Fibonacci();

void Generate20Fibonacci()
{
    List<int> fibonacciNumbers = [1, 1];
    Console.Write("The Fibonacci sequence is (first 20): 1, 1");
    int count;
    while (fibonacciNumbers.Count < 20){
        count = fibonacciNumbers.Count;
        fibonacciNumbers.Add(
            fibonacciNumbers[count - 1] + fibonacciNumbers[count - 2]
        );
        Console.Write($", {fibonacciNumbers[fibonacciNumbers.Count - 1]}");
    }
    Console.WriteLine();
    string e = Console.ReadLine("How are you? ");
    Console.WriteLine(e);
}

void WorkWithStrings()
{
    List<string> names = ["Daniel", "Ana", "Felipe"];
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
    Console.WriteLine();
    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Ana");
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine($"\nMy name is {names[0]}");
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

    Console.WriteLine($"\nThe list has {names.Count} people in it");

    var index = names.IndexOf("Felipe");
    if (index != -1)
    {
        Console.WriteLine($"\nThe name {names[index]} is at index {index}");
    }
    else
    {
        Console.WriteLine("The name Felipe is not in the list");
    }

    index = names.IndexOf("Not Found");
    if (index == -1)
    {
        Console.WriteLine($"\nWhen an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {names[index]} is at index {index}");
    }

    names.Sort();
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
}