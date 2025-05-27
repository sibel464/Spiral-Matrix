using System;

class SpiralMatrixFill
{
    public static int[,] GenerateSpiralMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        
        int value = 1;
        int top = 0, bottom = n - 1;
        int left = 0, right = n - 1;
        
        while (top <= bottom && left <= right)
        {
            // Üst satır soldan sağa
            for (int col = left; col <= right; col++)
                matrix[top, col] = value++;
            top++;
            
            // Sağ sütun yukarıdan aşağıya
            for (int row = top; row <= bottom; row++)
                matrix[row, right] = value++;
            right--;
            
            // Alt satır sağdan sola
            if (top <= bottom)
            {
                for (int col = right; col >= left; col--)
                    matrix[bottom, col] = value++;
                bottom--;
            }
            
            // Sol sütun aşağıdan yukarıya
            if (left <= right)
            {
                for (int row = bottom; row >= top; row--)
                    matrix[row, left] = value++;
                left++;
            }
        }
        
        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int n = 4; // Matris boyutu (4x4)
        int[,] spiralMatrix = GenerateSpiralMatrix(n);

        Console.WriteLine($"{n}x{n} Spiral Matrix:");
        PrintMatrix(spiralMatrix);
    }
}
