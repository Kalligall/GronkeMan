using System.Security.Cryptography.X509Certificates;

namespace Rooms
{
    class Room
    {
        //Create a gameboard 10x10 movables spaces with exits 1 exit per "wall" out of the room"
        
        public static void CreateRoom()
        {
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
    }
}