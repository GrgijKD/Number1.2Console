using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int number;
        bool isValid;
        
        do
        {
            Console.WriteLine("Введіть ціле число:");
            string input = Console.ReadLine();

            isValid = int.TryParse(input, out number);

            if (!isValid)
            {
                Console.WriteLine("Неправильне число. Спробуйте ще раз.");
            }

        } while (!isValid);

        Console.WriteLine($"Ви ввели число {number}");
    }
}