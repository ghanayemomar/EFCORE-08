using EF007;
using System;

namespace EF007
{
    class Program
    {
        // Step #1: Package Manager Console (PMC)
        //    Tools -> Nuget Package Manager -> Package Manager Console

        // Step #2: Package Manager Console (PMC) Tool 
        //    Install-Package Microsoft.EntityFrameworkCore.Tools

        // Step #3: Install Nuget Page on Project Microsoft.EntityFrameworkCore.Design
        // Microsoft.EntityFrameworkCore.SqlServer

        // Step #4: Install Provider in the project Microsoft.EntityFrameworkCore.SqlServer

        // Step #5: Run Command (Full)
        //    Scaffold-DbContext '[Connection String]' [Provider]


        // ---------------------------------------- Using Terminal ---------------------------------

        // Step #1: Windows Terminal (Command Prompt) 

        // Step #2: Install Ef-Core tool globally
        //    dotnet tool install --global dotnet-ef    (new)
        //    dotnet tool update --global dotnet-ef     (to upgrade)

        // Step #3: Install Provider in the project Microsoft.EntityFrameworkCore.SqlServer

        // Step #4: Run Command (Full)
        //    dotnet ef dbcontext scaffold '[Connection String]' [Provider]

        public static void Main()
        {
            //foreach (var item in new TechTalkContext().Speakers)
            //{
            //    Console.WriteLine(item.FirstName + " " ,item.LastName); 

            //}
        }


    }
}