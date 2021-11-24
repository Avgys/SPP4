using System;
using System.Collections.Generic;
using TestsGenerator.Lib;
using TestsGenerator.Stream;

namespace TestsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var readPaths = new List<string>()
            {
                "../../../../TestClasses/BasicTest.cs",
                "../../../../TestClasses/SmartTest.cs"
            };

            var config = new TestsGeneratorConfig(AsyncFileStream.ReadFromFile, AsyncFileStream.WriteToFile, 2, 2, 2);
            config.ReadPaths.AddRange(readPaths);

            new NUnitTestsGenerator(config).GenerateClasses().Wait();
            Console.WriteLine("Generated");
        }
    }
}
