namespace Lab2
{
    internal class Lab2
    {
        static void Main(string[] args)
        {
            int countRow = 0;

            int rows = 3;
            int cols = 3;

            int[,] matrix = new int [rows, cols];

            Random r = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = r.Next(-4, 50);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // task1 - Number of rows that doesn't contain zero

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool hasZeros = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        hasZeros = true;
                        break;
                    }
                }
                if (!hasZeros)
                {
                    countRow++;
                }
            }
            Console.WriteLine("Кількість рядків, які не містять нульових елементів: " + countRow);

            // task2 - Number of repetitions of the maximum value in the matrix
            int max = matrix[0, 0];
            int countMaxNumRepeat = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Максимальне значення: " + max);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((matrix[i, j] == max))
                    {
                        countMaxNumRepeat++;
                    }
                }
            }
            Console.WriteLine("Кількість повторів максимального значення в матриці: " + countMaxNumRepeat);
        }
    }
}