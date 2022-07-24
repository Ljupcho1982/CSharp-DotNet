
try
{
Console.WriteLine("Write you age");

string y = Console.ReadLine();
    Convert.ToInt32(y);

Console.WriteLine(y);   



}
catch (Exception ex)
{

    Console.WriteLine(ex.Message+ex.StackTrace);
}







