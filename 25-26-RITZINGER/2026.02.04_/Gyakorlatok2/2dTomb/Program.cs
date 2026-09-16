namespace _2dTomb
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = new int[3, 4]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
            };

            //Kiirás soronként
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i,j] + "");
                }
                Console.WriteLine();
            }

            //Kiirás ozsloponként
            for (int j = 0; j < 4; j++) 
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(matrix[i, j] + "");
                }
                Console.WriteLine();
            }
            /*
             * 1 5 9
               2 6 10
               4 8 12
             */
        }
    }
}
