using UtilityLibraries;

Console.Write("Enter a string: ");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No input provided.");
}
else
{
    Console.WriteLine($"Starts with uppercase? {input.StartsWithUpper()}");
}