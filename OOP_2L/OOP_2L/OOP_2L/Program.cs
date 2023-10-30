using OOP_2L;

namespace Game
{
    public class Program
    {
        static void Main()
        {
            var first_user = new DoubleDeductionPointsGameAccount("Anna");
            var second_user = new DoublePointsGameAccount("Nastya");

            Factory gameFactory = new Factory();
            var firstGame = gameFactory.CreateStandartGame(first_user, second_user);

            first_user.WinGame(firstGame);
            second_user.LoseGame(firstGame);

            var secondGame = gameFactory.CreateWithoutDeductionPointsGame(first_user, second_user);

            first_user.LoseGame(secondGame);
            second_user.WinGame(secondGame);

            var thirdGame = gameFactory.CreateStandartGame(first_user, second_user);

            first_user.LoseGame(thirdGame);
            second_user.WinGame(thirdGame);

            var forthGame = gameFactory.CreateStandartGame(first_user, second_user);

            first_user.LoseGame(forthGame);
            second_user.WinGame(forthGame);

            first_user.GetStats();
            Console.WriteLine("\n");
            second_user.GetStats();

        }
    }
}




