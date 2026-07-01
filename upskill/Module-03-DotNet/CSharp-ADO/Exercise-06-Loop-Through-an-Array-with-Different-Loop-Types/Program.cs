// C# Exercise 6
string[] workshopSessions = ["Registration", "Keynote", "Lab Session", "Break", "Review"];

Console.WriteLine("for loop — numbered session list:");
for (int index = 0; index < workshopSessions.Length; index++)
    Console.WriteLine($"  {index + 1}. {workshopSessions[index]}");

Console.WriteLine("\nforeach loop — uppercase session names:");
foreach (var session in workshopSessions)
    Console.WriteLine($"  {session.ToUpperInvariant()}");

Console.WriteLine("\nwhile loop — stop before Review:");
int pointer = 0;
while (pointer < workshopSessions.Length)
{
    if (workshopSessions[pointer] == "Review")
        break;

    Console.WriteLine($"  {workshopSessions[pointer]}");
    pointer++;
}

Console.WriteLine("\ndo-while loop — print last two sessions:");
int reverseIndex = workshopSessions.Length - 1;
do
{
    Console.WriteLine($"  {workshopSessions[reverseIndex]}");
    reverseIndex--;
} while (reverseIndex >= workshopSessions.Length - 2);
