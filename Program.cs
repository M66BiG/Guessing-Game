internal class Program
{
    private static void Main(string[] args)
    {
        Random guess = new Random();
        int random = guess.Next(1,101);
        int input;
        do
        {
            Console.WriteLine("Errate die Zahl");
            input = Convert.ToInt32(Console.ReadLine());

            if (input < random)
            {
                Console.WriteLine("Zu niedrig. Versuch es noch einmal.");
                Thread.Sleep(1000);
            }
            else if (input > random)
            {
                Console.WriteLine("Zu hoch. Versuch es noch einmal.");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine($"Du hast es geschafft. Die richtige Zahl war: {random}.");
            }
        }while (random != input);
    }
}