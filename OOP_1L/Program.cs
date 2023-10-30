using OOP_1L;

namespace Game
{
    public class Program
    { 
        static void Main()
        {
            var first_user = new GameAccount("Anna");
            var second_user = new GameAccount("Nastya");

            first_user.WinGame(300, second_user.UserName);
            first_user.LoseGame(400, second_user.UserName);
            first_user.WinGame(200, second_user.UserName);
            second_user.WinGame(100, first_user.UserName);

            first_user.GetStats();
            Console.WriteLine("\n");
            second_user.GetStats();

            try
            {
                first_user.LoseGame(-1100, second_user.UserName);
                second_user.WinGame(1100, first_user.UserName);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
                return;
            }

            first_user.GetStats();
            Console.WriteLine("\n");
            second_user.GetStats();
        }
    }
}

 


