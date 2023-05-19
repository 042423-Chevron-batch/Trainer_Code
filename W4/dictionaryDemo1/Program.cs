using dictionaryDemo1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Dictionary<Person, int> people = new Dictionary<Person, int>();

        Person p1 = new Person("Mark", 1);
        Person p2 = new Person("Ishmael", 2);
        Person p3 = new Person("Jvon", 3);
        Person p4 = new Person("Avery", 4);
        Person p5 = new Person("Clint", 5);
        Person p6 = new Person("Dan", 6);

        people.Add(p1, 1);
        people.Add(p2, 2);
        people.Add(p3, 3);
        people.Add(p4, 4);
        people.Add(p5, 5);
        people.Add(p6, 6);

        Console.WriteLine(people.ContainsKey(p4));
        foreach (KeyValuePair<Person, int> p in people)
        {
            Console.WriteLine($"{p.Key.Name} is {p.Value} ");

        }



    }
}