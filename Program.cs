// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(checkIfCharIsPalindrome("NITIN"));
Console.WriteLine(checkIfCharIsPalindrome("123454321"));
Console.WriteLine(checkIfCharIsPalindrome("ANDREW"));

static bool checkIfCharIsPalindrome(string n)
{
    //bool isPalindrom = false;
    //NITIN
    /*
     [0] = N
     [1] = I
     [2] = T
     [3] = I
     [4] = N
    123454321,
     [0] = 1
     [1] = 2
     [2] = 3
     [3] = 4
     [4] = 5
     [5] = 4
     [6] = 3
     [7] = 2
     [8] = 1
     */
    char[] str = n.ToArray();
    double arrLen = Math.Round((double)str.Length / 2, MidpointRounding.AwayFromZero);
    Console.WriteLine(arrLen);
    for (int i = 0; i < arrLen; i++)
    {
        //Console.WriteLine(str[i]);
        Console.WriteLine("arr[" + i + "]" + str[i]);
        Console.WriteLine("arr[" + ((str.Length - 1) - i) + "]" + str[(str.Length - 1) - i]);
        if (str[i] != str[(str.Length - 1) - i])
        {
            return false;
        }
    }
    return true;
    // return isPalindrom;
}
