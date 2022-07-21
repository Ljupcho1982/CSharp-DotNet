using System.Text;
using static System.Console;
using System.Threading;
Console.OutputEncoding = Encoding.UTF8;

WriteLine("Tic-tac-toe, noughts and crosss, или Xs and Os е игра со хартија и молив за двајца играчи кои наизменично ги обележуваат празнините во мрежа од три на три со X или O.\n\r Играчот кој ќе успее да постави три од нивните оценки во хоризонтален, вертикален или дијагонален ред е победник");

/// Initializing a new character array with 9 characters

 char[] spaces = new char[] { '1', '2', '3', '4', '5', '6', '7', '8','9'};
 int player = 1;
 int choice;
 int flag;
/// <summary>
/// creating Game Board
/// </summary>
/// 
     static void DrawBoard(char[] spaces)
{
    WriteLine("     |     |     ");
    WriteLine("   {0} |   {1} |  {2}   ",spaces[0],spaces[1],spaces[2]);
    WriteLine("_____|_____|_____");
    WriteLine("     |     |     ");
    WriteLine("   {0} |{1}    |   {2}  ",spaces[3],spaces[4],spaces[5]);
    WriteLine("     |     |     ");
    WriteLine("_____|_____|_____");
    WriteLine("  {0}  |{1}    |  {2}   ", spaces[6],spaces[7],spaces[8]);
    WriteLine("     |     |     ");

};

///<sumary>
///Check if the game was won, tied or should continue
/// </sumary>
static int CheckWin(char[] spaces)
{
    /// Check if the first row is ocupated
    if (spaces[0] == spaces[1] && spaces[1] == spaces[2] || ///row1
        spaces[3] == spaces[4] && spaces[4] == spaces[5] ||  ///row2
        spaces[6] == spaces[7] && spaces[7] == spaces[8] || ///row3
        spaces[0] == spaces[3] && spaces[3] == spaces[6] || ///column 1
        spaces[1] == spaces[4] && spaces[4] == spaces[7] || ///column 2
        spaces[2] == spaces[5] && spaces[5] == spaces[8] || ///column 3
        spaces[0] == spaces[4] && spaces[4] == spaces[8] || ///diagonal 1
        spaces[2] == spaces[4] && spaces[4] == spaces[6] ///diagonal 2


        )

    {
        return 1;
    }
    else if (spaces[0] != '1' &&
            spaces[1] != '2' &&
            spaces[2] != '3' &&
            spaces[3] != '4' &&
            spaces[4] != '5' &&
            spaces[5] != '6' &&
            spaces[6] != '7' &&
            spaces[7] != '8' &&
            spaces[8] != '9' )
    {
        return -1;
    }
    else
    {
        return 0;
    }
       
}

///<summary>
///Draws an X on the game board
/// </summary>
/// <param name="pos"></param>

static void DrawX(int pos, char[] spaces)
{
    spaces[pos] = 'X';

};

///<summary>
///Draws an O on the game board
/// </summary>
/// /// <param name="pos"></param>

static void DrawO(int pos, char[] spaces)
{
    spaces[pos] = 'O';

};
///<summary>
///Do While Loop
///</summary>
do
{
    Console.Clear();
    WriteLine("Player 1:X and Player 2:O" + "\n");
    if (player % 2 == 0)
    {
        WriteLine("Player 2`s turn");

    }
    else
    {
        WriteLine("Player 1`s turn");
    }

    WriteLine("\n");
    DrawBoard(spaces);
    choice = int.Parse(Console.ReadLine())-1;
    if (spaces[choice] != 'X' && spaces[choice] != 'O')
    {

        if (player % 2 == 0)
        {
            DrawO(choice, spaces);
        } else
            DrawX(choice, spaces);
 player++;
    } else
   

   
{
    WriteLine("Sorry the row{0} is already marked with {1} \n", choice, spaces[choice]);
    WriteLine("Please wait 2 seconds board is loading again.....");
    Thread.Sleep(2000);

}
flag = CheckWin(spaces);
}while (flag != 1 && flag != -1) ;
Console.Clear();
DrawBoard(spaces);
if (flag != 1)
{

    WriteLine("Player{0} has won", (player % 2) + 1);
}
else
{

    WriteLine("Tie Game");
}
ReadLine();
