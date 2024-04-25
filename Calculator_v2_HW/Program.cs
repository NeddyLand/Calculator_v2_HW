namespace Calculator_v2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine($"{calc} + 7 = {calc + 7}");
            Console.WriteLine($"7 + {calc} = {7 + calc}");
            Console.WriteLine($"{calc} - 7 = {calc - 7}");
            Console.WriteLine($"7 - {calc} = {7 - calc}");
            Console.WriteLine($"{calc} * 7 = {calc * 7}");
            Console.WriteLine($"7 * {calc} = {7 * calc}");
            Console.WriteLine($"{calc} / 7 = {calc / 7}");
            Console.WriteLine($"98 / {calc} = {98 / calc}");
            Console.WriteLine();
            Console.WriteLine($"{calc} + 8.5 = {calc + 8.5}");
            Console.WriteLine($"8.5 + {calc} = {8.5 + calc}");
            Console.WriteLine($"{calc} - 8.5 = {calc - 8.5}");
            Console.WriteLine($"8.5 - {calc} = {8.5 - calc}");
            Console.WriteLine($"{calc} * 8.5 = {calc * 8.5}");
            Console.WriteLine($"8.5 * {calc} = {8.5 * calc}");
            Console.WriteLine($"{calc} / 8.5 = {calc / 8.5}");
            Console.WriteLine($"8.5 / {calc} = {8.5 / calc}");
        }
    }
}
