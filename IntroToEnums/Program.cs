namespace IntroToEnums
{
    internal class Program
    {
        enum Day
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        enum CardValue
        {
            Two = 2,
            Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
        }

        enum Suit
        {
            Heart, Diamond, Club, Spade
        }

        static void Main(string[] args)
        {
            // days of the week

            //Console.Write("Enter day number (0-6): ");
            //int dayNum = int.Parse(Console.ReadLine());

            //Day day = (Day)dayNum;

            //Console.WriteLine("It is: " + day);


            // playing card example

            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                CardValue cardValue = (CardValue)rnd.Next(2, 15);
                Suit suit = (Suit)rnd.Next(4);

                Console.WriteLine(cardValue + " of " + suit);
            }
        }
    }
}
