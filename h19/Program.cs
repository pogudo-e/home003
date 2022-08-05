int a = 12821;
int b = 35235;

void Palindrome(int num)
{
    string myString = num.ToString();
    bool res = myString.SequenceEqual(myString.Reverse());
    if (res)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

}

Palindrome(a);
Palindrome(b);
