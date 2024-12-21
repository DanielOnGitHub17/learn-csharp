#pragma warning disable CS8321
// WorkWithIntegers();
// OrderPrecedence();
// TestLimits();
// WorkWithDoubles();
// WorkWithDecimals();
PiFinder();


void PiFinder()
{
    double pi = Math.PI;
    double radius = 2.5;
    double area = pi * Math.Pow(radius, 2);
    Console.WriteLine(area);
}

void WorkWithDecimals()
{
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of decimal is {min} to {max}");

    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d);

    decimal e = (decimal)(a / b);
    Console.WriteLine(e);
}

void WorkWithDoubles()
{
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);

    double e = 19;
    double f = 23;
    double g = 8;
    double h = (e + f) / g;
    Console.WriteLine(h);

    // get min and max of double
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");

    // rounding errors?
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

void TestLimits()
{
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");

    // printing out the maximum and minimum values for integers
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    // checking max value wrapping
    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
    // testing with multiplication by 2
    what = max * 2;
    Console.WriteLine($"Another example of overflow: {what}");
}

void WorkWithIntegers()  // 
{
    // addition
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);

    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
    Console.WriteLine(8/3);
}