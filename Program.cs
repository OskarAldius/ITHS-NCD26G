using System.Net.NetworkInformation;

namespace simpleGit;

class Program
{
    static void Main()
    {
       System.Console.WriteLine("Hello Git!");
       System.Console.WriteLine(DoSomething("Michael"));
    }
    static string DoSomething(string name)
    {
        
        return $"hello{name}";
    }
}
