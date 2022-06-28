// See https://aka.ms/new-console-template for more information
for (; ; )
{
    Console.WriteLine("1st Value");
    string str1 = Console.ReadLine();
    double int1 = Convert.ToDouble(str1);
    Console.WriteLine("Symbol");
    string sym = Console.ReadLine();
    Console.WriteLine("2nd Value");
    string str2 = Console.ReadLine();
    double int2 = Convert.ToDouble(str2);

    if (sym == "+")
    { Console.WriteLine(int1 + int2); }

    if (sym == "-")
    { Console.WriteLine(int1 - int2); }

    if (sym == "*")
    { Console.WriteLine(int1 * int2); }

    if (sym == "/")
    { Console.WriteLine(int1 / int2); }
    Console.WriteLine("Press enter to continue");
    Console.ReadKey();
    Console.Clear();
}