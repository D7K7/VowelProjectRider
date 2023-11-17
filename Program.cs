int count = 0;
string vowels = "aeiouAEIOU";
string str = Console.ReadLine();

foreach (char c in str)
{
    if (vowels.Contains(c))
    {
        count++;
    }
}

return count;
