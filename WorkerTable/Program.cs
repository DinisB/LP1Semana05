using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Table tabela;
            Randomizer.Seed = new Random(int.Parse(args[0]));
            tabela = new Table();
            Faker faker = new Faker("pt_PT");
            tabela.AddColumn("ID");
            tabela.AddColumn("Name");
            tabela.AddColumn("Job");
            int count = int.Parse(args[0]);
            for (int i = 0; i < count; i++)
            {
                int fakerid = i;
                string randomName = faker.Parse("{{name.lastName}}, {{name.firstName}} {{name.suffix}}");
                string randomJob = faker.Parse("{name.fullJob}");

            tabela.AddRow(fakerid, randomName, randomJob);
            }
            AnsiConsole.Write(tabela);
        }
    }
}
