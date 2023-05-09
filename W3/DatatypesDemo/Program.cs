using System;
namespace DatatypesDemo;
class Program
{
    static void Main(string[] args)
    {
        //get an input from the user
        Console.WriteLine($"Please input a value. Any value... Literally any value.. For real.");
        string? input = Console.ReadLine();

        // box the string
        // boxing is when you encapsulate a value into an object type.
        // object? obj = input;

        //call a method to see what datatype the value is
        // string? ret = (string)GetMyStringValue(obj!);// 
        // Console.WriteLine($"The returned value is {ret}.");


        // now lets convert to get a value
        object obj2 = DeciferTheValue(input!);
        Console.WriteLine($"The returned value of obj2 is {obj2.ToString()}.");

    }

    /// <summary>
    /// this method takes an object and checks what the underlying datatype is. 
    /// Then it takes action base on the underlying datatype,
    /// </summary>
    /// <param name="y"></param>
    /// <returns></returns>
    public static object GetMyStringValue(object y)
    {
        if (y is int)
        {
            int yy = (int)y;
            yy *= yy;
            object yyy = yy;
            return yyy;
        }
        else if (y is string)
        {
            string yy = (string)y;
            yy += y;// yy = yy + y; this include IMPLICIT unboxing of the string
            return yy;
        }
        return y;
    }

    /// <summary>
    /// this method will test for the correct conversion and return a boxed string telling what datatype the value was.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    static object DeciferTheValue(string s)// s is a parameter of the method
    {
        int i;
        double d;
        long l;
        //add some more? char? float? decimal? bool?

        if (Int32.TryParse(s, out i))
        {
            string ss = $"this value is an integer ->{i}";
            object obj = ss;
            return ss;
        }
        else if (Int64.TryParse(s, out l))
        {
            string ss = $"this value is a long -> {l}";
            object obj = ss;
            return ss;
        }
        else if (Double.TryParse(s, out d))
        {
            string ss = $"this value is a double -> {d}";
            object obj = ss;
            return ss;
        }
        else
        {
            return "seats taken - It's  string (or null).";
        }

    }
}
