namespace TheFivePrototypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Point Class
            Point point1 = new(2, 3);
            Point point2 = new(-4, 0);

            Console.WriteLine($"point1: {point1.XCord}, {point1.YCord}.");
            Console.WriteLine($"point2: {point2.XCord}, {point2.YCord}.");

            // Testing Color Class

            Color myCustomColor = new(234, 23, 72);
            Color red = Color.Red();

            myCustomColor.PrintColorValues();
            red.PrintColorValues();

            // Testing Card Class

            Card[] newDeck = Card.DeckOfCards();

            foreach (Card card in newDeck)
            {
                card.PrintCardName();
            }

            // Testing Door Class

            Console.WriteLine("Let's play a door game. Enter a passcode for your door and start the game.");

            int.TryParse(Console.ReadLine(), out int passcode);

            Door currentDoor = new(passcode);

            Console.Clear();

            while (true)
            {
                Console.WriteLine($"The door is currently {currentDoor.DoorStatus}. What would you like to do?");

                for (int i = 0; i < currentDoor.Actions.Count; i++)
                {
                    Console.WriteLine($"{i}: {currentDoor.Actions[i].Label}");
                }

                int.TryParse(Console.ReadLine(), out int response);

                currentDoor.Actions[response].Command();
            }

            //Testing PasswordValidator Class

            while (true)
            {
                Console.WriteLine("Enter a password");
                string? password = Console.ReadLine();

                if (password == null) break;

                if (PasswordValidator.ValidPassword(password))
                {
                    Console.WriteLine("Valid Password");
                }
                else
                {
                    Console.WriteLine("invalid password");
                }
            }
        }
    }
}