// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> firstGroup = new List<int>();
List<int> secondGroup = new List<int>();

Console.WriteLine("Digite 12 números entre 1 e 20: ");

for (int x = 0; x <= 12; x++)
{
    String input = Console.ReadLine();
    int number = Int32.Parse(input);

    if (number <= 10 && number % 2 == 0)
    {
        firstGroup.Add(number);
    }
    if (number > 10)
    {
        secondGroup.Add(number);
    }
}

string add1 = "";
firstGroup.ForEach(n => add1 += n + " ");
Console.WriteLine("Lista 1: " + add1);

string add2 = "";
secondGroup.ForEach(n => add2 += n + " ");
Console.WriteLine("Lista 2: " + add2);