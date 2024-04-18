using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instância MilitaryUnit
            MilitaryUnit militaryUnit = new MilitaryUnit(2, 10, 4);

            //Instância SettlerUnit
            SettlerUnit settlerUnit = new SettlerUnit();

            //Método Move
            militaryUnit.move(3);
            settlerUnit.move(2);

            //Imprime Health e Cost da MilitaryUnit
            Console.WriteLine($"Health da MilitaryUnit: {militaryUnit.Health}");
            Console.WriteLine($"Cost da MilitaryUnit: {militaryUnit.Cost}");
            
            //Imprime Health e Cost da SettlerUnit
            Console.WriteLine($"Health da SettlerUnit: {settlerUnit.Health}");
            Console.WriteLine($"Cost da SettlerUnit: {settlerUnit.Cost}");
        }
    }
}
