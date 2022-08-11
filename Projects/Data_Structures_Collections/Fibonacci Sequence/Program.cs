//Fibonacci Sequence

//without Loop
 static int fib(int n)
{

    if(n==0||n == 1)
    {

        return n;
    }

        return fib(n - 1) + fib(n - 2);

}

Console.WriteLine(fib(11));

//with Loop


  static int fib2(int n)
{


    if (n == 0 || n == 1) { return n; }
    int sLast = 0;
    int last = 1;
    int curPos = 2;

    while (curPos <= n)
    {

        int temp = last;
        last = last + sLast;
        sLast = temp;
        curPos++;
    }

    return last;
}

Console.WriteLine(fib2(11));
    


    



