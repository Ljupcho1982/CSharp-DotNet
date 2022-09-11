using System.Reflection;

Type t = typeof(int);

MemberInfo[] typeMembers= t.GetMembers();

foreach(MemberInfo memberInfo in typeMembers)
{

    Console.WriteLine("Member = " + memberInfo);
}

FieldInfo[] typeFields=t.GetFields();

foreach(FieldInfo field in typeFields)
{

    Console.WriteLine("Field= " + field);
}

MethodInfo[] typeMethods = t.GetMethods();

foreach(MethodInfo method in typeMethods)
{

    Console.WriteLine("Methods = " + method);
}

