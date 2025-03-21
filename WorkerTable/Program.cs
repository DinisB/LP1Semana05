using System;
using Spectre.Console;
using Bogus;
using Bogus.DataSets;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Table tabela = new Table();
            Faker faker = new Faker("pt_PT");
            tabela.AddColumn("ID");
            tabela.AddColumn("Name");
            tabela.AddColumn("Job");
            int count = int.Parse(args[0]);
            for (int i = 0; i < count; i++)
            {
                Name name = faker.Name;
                tabela.AddRow($"{(i + 1)}", $"{name.FirstName()} {name.LastName()}", name.JobTitle());
            }
            AnsiConsole.Write(tabela);
        }
    }
}
