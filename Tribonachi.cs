using System;

class GFG
{

    // Recursion Function
    static int printTribRec(int n)
    {

        if (n == 0 || n == 1 || n == 2)
            return 0;

        if (n == 3)
            return 1;
        else
            return printTribRec(n - 1) +
                   printTribRec(n - 2) +
                   printTribRec(n - 3);
    }

    static void printTrib(int n)
    {
        for (int i = 1; i <= n; i++)
            Console.Write(printTribRec(i) + " ");
    }

    // Driver code
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        printTrib(n);
    }
}
