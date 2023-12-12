using System.Xml.Linq;

namespace C__Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part part1 = new Part(1, "Resistor", 450, 0, 100);
            Part part2 = new Part(2, "Capacitor", 12, 100, 1000);

            Console.WriteLine($"{part1}");
            Console.WriteLine($"{part2}");

            while (true)
            {
                int numParts;
                string opt = PrintMenu1();
                string selectionStr = PrintMenu2();

                try
                {
                    if (opt == "entf")
                    {
                        Console.Write("Wie viele Parts?");
                        numParts = Convert.ToInt32(Console.ReadLine());

                        if (selectionStr == "1")
                        {
                            part1.RemoveParts(numParts);
                            part1.Output();
                        }

                        else if (selectionStr == "2") 
                        {
                            part2.RemoveParts(numParts);
                            part2.Output();
                        }
                    }
                    else if (opt == "add")
                    {
                        Console.Write("Wie Viele Parts?");
                        numParts = Convert.ToInt32(Console.ReadLine());

                        if (selectionStr == "1")
                        {
                            part1.AddParts(numParts);
                            part1.Output();
                        }

                        else if (selectionStr == "2")
                        {
                            part2.AddParts(numParts);
                            part2.Output();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }

        static string PrintMenu1()
        {
            string menu1 = @"
Folgende Möglichkeiten hast du:
    entf - Entferne Teile aus dem Lager
    add  - Füge Teile dem Lager hinzu";

            Console.WriteLine(menu1);

            string selectedOption;
            do
            {
                Console.Write("Deine Wahl: ");
                selectedOption = Console.ReadLine();
            } while (selectedOption != "entf" && selectedOption != "add");
            return selectedOption;
        }

        static string PrintMenu2()
        {
            string menu2 = @"
Wähle das Lager aus das du Bearbeiten möchtest:
    1 : 
    2 :";
            Console.WriteLine(menu2);

            string selectedStorage;
            do
            {
                Console.Write("Deine Wahl: ");
                selectedStorage = Console.ReadLine();
            } while (selectedStorage != "1" && selectedStorage != "2");
            return selectedStorage;
        }
    }

}