namespace Refactoring;

public class Fibonacci
{
    public static int Fib(int n)
    {
        switch (n)
        {
            case 0:
            case 1:
                return n;
            case < 0:
                throw new ArgumentOutOfRangeException("Number is less then 0");
        }

        int a = 0;
        int b = 1;
        while (n-- > 1)
        {
            int t = a;
            a = b;
            b += t;
        }
        return b;
    }
}