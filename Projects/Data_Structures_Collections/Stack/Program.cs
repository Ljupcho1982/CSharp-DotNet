using System.Collections.Generic;
using System.Diagnostics;

Stack<string> s = new Stack<string>();

s.Push("a");
s.Push("b");

Console.WriteLine("The stack contains " + s.Count + " elements");


private static bool isBalanced(string inputString)
{

    Stack<char> stackOfOpeningBraces = new Stack<char>();
    Stack<char> stackOfClosingBraces = new Stack<char>();

    foreach(char c in inputString)
    {

        if(c=='}' || c==']'|| c==')')
        {

            stackOfClosingBraces.Push(c);
        }
    }

    for(int i=inputString.Length-1; i>=0; i--)
    {

        if(inputString[i]=='{' || inputString[i]=='[' || inputString[i] == '(')
        {

            stackOfOpeningBraces.Push(inputString[i]);
        }
        if((stackOfOpeningBraces.Count+stackOfClosingBraces)%2 != 0)
        {

            return false;
        }

        while (stackOfClosingBraces.Count !=0)
        {
            char currentClosingBraces = stackOfClosingBraces.Pop();
            char currentOpeningBraces = stackOfOpeningBraces.Pop();
        if((currentClosingBraces=='}' && currentOpeningBraces=='{') || (currentClosingBraces==']' && currentClosingBraces==']')|| (currentClosingBraces==')' && currentOpeningBraces=='[')||(currentClosingBraces==')' && currentClosingBraces == '('))
            {

                continue;
            }
            else
            {
                return false;
            }

        }

        return true;
    }
}