using System.Reflection;


Console.WriteLine("Is string generic type?" + typeof(string).IsGenericType);

Console.WriteLine("Is list generic type?" + typeof(List<>).IsGenericType);

Type t = typeof(Dictionary<,>);

if (t.IsGenericType)
{

    Type[] types = t.GetGenericArguments();

    Console.WriteLine("Number of type parameters ={0}", types.Length);

    foreach(Type param in types)
    {

        if (param.IsGenericParameter)
        {

            Console.WriteLine("Generic Type = {0}", param);
        }
        else
        {

            Console.WriteLine("Type={0}",param);
        }
    }


}
