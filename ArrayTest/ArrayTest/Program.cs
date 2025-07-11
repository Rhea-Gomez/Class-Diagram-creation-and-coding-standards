namespace ArrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colours = { "red", "blue", "green", "yellow", "violet", "white" };

            Console.WriteLine("Using For loop: ");
            for(int i = 0; i < colours.Length; i++)
            {
                Console.WriteLine(colours[i]);
            }

            Console.WriteLine("Using For Each: ");
            foreach(string colour in colours)
            {
                Console.WriteLine(colour);
            }
        }
    }
}
