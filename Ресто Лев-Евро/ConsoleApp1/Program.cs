namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int value1 = 0;
            int value2 = 0;
            double billLev = 0;
            double billEuro= 0;
            double receivedLev = 0;
            double receivedEuro = 0;
            double changeLev = 0;
            double changeEuro = 0;

            Console.WriteLine("Изберете (1) за евро или (2) за лева, след това въведете дължимата сума от клиента!");
            value1 = Int32.Parse(Console.ReadLine());
            if (value1 == 1) {

                Console.WriteLine("Въведете дължимата сума в евро:");
                billEuro = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Дължима сума: {Math.Round(billEuro * 1.96)}лева");
                Console.WriteLine("Изберете (1) за евро или (2) за лева, след това въведете получената сума от клиента!");
                value2 = Int32.Parse(Console.ReadLine());
                if (value2 == 1) {

                    Console.WriteLine("Въведете получената сума от клиента в евро:");
                    receivedEuro = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"Получена сума: {Math.Round(receivedEuro *1.96)}лева");
                    changeEuro = receivedEuro - billEuro;
                    changeLev = (receivedEuro - billEuro) *1.96;
                    Console.WriteLine($"Рестото на клиента: {Math.Round(changeEuro)} евро или {Math.Round(changeLev)} лева");

                }
                if (value2 == 2)
                {

                    Console.WriteLine("Въведете получената сума от клиента в лева:");
                    receivedLev = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"Получена сума: {Math.Round(receivedLev *0.51)}евро");
                    changeEuro = receivedLev *0.51 - billEuro;
                    changeLev = receivedLev - billEuro *1.96;
                    Console.WriteLine($"Рестото на клиента: {Math.Round(changeEuro)} евро или {Math.Round(changeLev)} лева");

                }

            }

            if (value1 == 2)
            {

                Console.WriteLine("Въведете дължимата сума в лева:");
                billLev = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Дължима сума: {Math.Round(billLev * 0.51)}евро");
                Console.WriteLine("Изберете (1) за евро или (2) за лева, след това въведете получената сума от клиента!");
                value2 = Int32.Parse(Console.ReadLine());
                if (value2 == 1)
                {

                    Console.WriteLine("Въведете получената сума от клиента в евро:");
                    receivedEuro = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"Получена сума: {Math.Round(receivedEuro * 1.96)}лева");
                    changeEuro = receivedEuro - billLev * 0.51;
                    changeLev = receivedEuro * 1.96 - billLev;
                    Console.WriteLine($"Рестото на клиента: {Math.Round(changeEuro)} евро или {Math.Round(changeLev)} лева");

                }
                if (value2 == 2)
                {

                    Console.WriteLine("Въведете получената сума от клиента в лева:");
                    receivedLev = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"Получена сума: {Math.Round(receivedLev * 0.51)}евро");
                    changeEuro = (receivedLev - billLev) * 0.51;
                    changeLev = receivedLev - billLev;
                    Console.WriteLine($"Рестото на клиента: {Math.Round(changeEuro)} евро или {Math.Round(changeLev)} лева");

                }

            }
            else
            {
                Console.WriteLine("Опитайте отново!");
                Console.WriteLine("Изберете (1) за евро или (2) за лева, след това въведете дължимата сума от клиента!");
                value1 = Int32.Parse(Console.ReadLine());
                return;
            }

        }
    }
}
