using System;

namespace Regex_
{
    public class Program
    {
        static void Main(string[] args)
        {
          pattern p = new pattern();
          Console.WriteLine( p.patterncheck("Aniket Jiotode", "aniket@gmail.com", "91 9623211205", "Pass@123"));
        }
    }
}
