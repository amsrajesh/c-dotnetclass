using System;


public class Program
{
    public static void Main(string[] args)
    {
        int[][] jArray = new int[][]{
                new int[3]{1, 2, 3},

                new int[]{4, 5, 6, 7,8},
                new int[]{9,10}
            };

        for (int i = 0; i < jArray.Length; i++)
        {
            for (int j = 0; j < (jArray[i]).Length; j++)
                Console.WriteLine(jArray[i][j]);
            Console.ReadLine();

        }

    }
}


