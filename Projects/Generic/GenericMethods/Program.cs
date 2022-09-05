using System;


namespace GenericMethods
{
    internal class Program
    {

    
     public static void Main(string[] args)
        {
            Example<string>.PrintMessage("hi");

            Example<int>.PrintMessage(1);

            Example<bool>.PrintMessage(false);

          


        }
    class Example<T>
        {

           public static void PrintMessage<T>(T message)
            {

                Console.WriteLine(message);
            }

            public static void PrintMesage<T>(T message, T prefix){

                Console.WriteLine(prefix.ToString() + message.ToString());
            
            }

            public static void PrintMessage<T>(T message, T sufix)
            {
                Console.WriteLine(sufix.ToString() + message.ToString());

            }

            public static void PrintMessage<T>(T message, T prefix, T suffix)
            {

                Console.WriteLine(prefix.ToString()+message+suffix.ToString());

            }
        }

    }
}
