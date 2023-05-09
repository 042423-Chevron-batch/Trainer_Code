namespace DatatypesDemo;
class Program
{
    static void Main(string[] args)
    {
        //get an input from the user
        Console.WriteLine($"Please input a value. Any value... Literally any value.. For real.");
        string? input = Console.ReadLine();

        // box the string
        object? obj = input;

        //call a method to see what datatype the value is
        object ret = GetMyStringValue(obj!);
        Console.WriteLine($"The returned value is {ret}.");


        // now lets convert to get a value
        object obj2 = DeciferTheValue(input!);
        Console.WriteLine($"The returned value of obj2 is {obj2.ToString()}.");

    }

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
            yy += y;
            return yy;
        }
        return y;
    }

    /// <summary>
    /// this method will test for the correct conversion and return a boxed string telling what datatype the value was.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    static object DeciferTheValue(string s)
    {
        int i;
        double d;
        long l;
        //add some more? char? float? decimal? bool?

        if (Int32.TryParse(s, out i))
        {
            string ss = "this value is an integer";
            object obj = ss;
            return ss;
        }
        else if (Double.TryParse(s, out d))
        {
            string ss = "this value is a double";
            object obj = ss;
            return ss;
        }
        else if (Int64.TryParse(s, out l))
        {
            string ss = "this value is a long";
            object obj = ss;
            return ss;
        }
        else
        {
            return "seats taken.";
        }

    }



}
