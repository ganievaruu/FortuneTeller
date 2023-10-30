namespace FortuneTeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("PLease enter your question: ");
                Console.ReadLine();

                Random yesNoMaybe = new Random();
                int answerNum = yesNoMaybe.Next(1, 4);

                if (answerNum == 1)
                {
                    Console.WriteLine("Yes");
                }
                else if (answerNum == 2)
                {
                    Console.WriteLine("Maybe");
                }
                else if (answerNum == 3)
                {
                    Console.WriteLine("No");
                }

                Console.ReadKey();

            }
        }
    }
}