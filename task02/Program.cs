string[] studentsG1 = new string[5];
string[] studentsG2 = new string[5];

for (int i = 0; i < 5; i++)
{
    int j;
    Console.Write("Enter " + (j = i + 1) + " student from G1: ");
    studentsG1[i] = Console.ReadLine();
}

for (int i = 0; i < 5; i++)
{
    Console.Write("Enter " + (i + 1) + " student from G2: ");
    studentsG2[i] = Console.ReadLine();
}

Console.WriteLine("Enter student group");
int.TryParse(Console.ReadLine(), out int group);

if (group == 1)
{
    Console.WriteLine("The Students in G1 are:");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(studentsG1[i]);
    }
}
else if (group == 2)
{
    Console.WriteLine("The Students in G2 are:");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(studentsG2[i]);
    }
}
else
{
    Console.WriteLine("Wrong input");
}