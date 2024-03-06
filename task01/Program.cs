int[] numbers = new int[6];
int sum = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write("Enter " + (i + 1) + " integer: ");
    bool success = int.TryParse(Console.ReadLine(), out numbers[i]);
    if (success)
    {
        continue;
    }
    else
    {
        Console.WriteLine("Wrong input");
    }
}
for (int i = 0; i < 6; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sum += numbers[i];
    }
}
Console.WriteLine("The result is: " + sum);