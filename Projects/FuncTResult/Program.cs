///Func<TResult> Func delegate

Func<int, int, int> multiply = (x, y) => { return x * y; };
/// <summary>
/// first come the Func delegate, in the tags comes the types of any parameters 
/// which are except by Lambda the lest type is the type will be returned
/// then comes the name of our function after that comes the Lambda experssion
/// </summary>
Console.WriteLine( multiply(3,2));


