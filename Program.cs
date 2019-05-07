using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChallengeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = Solution.ConvertCSVtoJSON(args[0], args[1]);
            Console.WriteLine(temp);
        }
    }
}
