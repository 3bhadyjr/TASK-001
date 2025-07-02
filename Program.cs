namespace TASK_001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Carpet cleaning service");

            Console.WriteLine("How many small carpets do you want to clean ? *25$ per carpet*");
            int smallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many larg carpets do you want to clean ? * 35$ per carpet*");
            int largeCarpet = Convert.ToInt32(Console.ReadLine());

            int costSmall = smallCarpet * 25;
            int costLarge = largeCarpet * 35;
            int totalCost = costSmall + costLarge;
            double tax = totalCost * 0.06;


            Console.WriteLine($"cost : {totalCost:C}");
            Console.WriteLine($"tax : {tax:C}");
            double total = totalCost + tax;
            Console.WriteLine($"cost + tax : {total:C}");

        }
    }
}
