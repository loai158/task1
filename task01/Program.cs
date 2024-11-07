namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Islam's Carpet Cleaning Service");
            Console.Write("Please Enter Number of small carpets : ");
            int sCarpet = int.Parse(Console.ReadLine());
            Console.Write("Please Enter Number of Large carpets : ");
            int lCarpet = int.Parse(Console.ReadLine());
            double cost = 25 * sCarpet + 35 * lCarpet;
            Console.WriteLine($"cost : {cost} ");
            double tax = 0.06 * cost;
            Console.WriteLine($"tax : {tax} ");
            double totalEstimate = cost + tax;
            Console.WriteLine($"Your Total Estimate is : {totalEstimate} $\n This estimate is valid for 30 days ");
            Console.ReadKey();
        }
    }
}
