while (true)
{
    Console.WriteLine("\n******************** Palindrome Start ********************\n");
    Console.Write("Please enter word : ");
    string word = Console.ReadLine()?.ToLower();

    string revers = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        revers += word[i];
    }

    if (revers == word)
    {
        Console.WriteLine($"Word : {word} : is Palindrome");
    }
    else
    {
        Console.WriteLine($"Word : {word} : is not Palindrome");
    }

    Console.WriteLine("\n******************** Palindrome End ********************\n");
}//while