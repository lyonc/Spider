namespace Clsmap.Spider
{
    using System;
    using Clsmap.Spider.Logics;
    using Clsmap.Spider.Logics.Rules;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            new Harvest().GoAsync(new AdministrativeDivisionProcess());

            Console.In.ReadLine();
        }
    }
}
