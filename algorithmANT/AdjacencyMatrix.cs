using System;

namespace algorithmANT
{
    internal class AdjacencyMatrix
    {
        private int[,] matrix; // Adjacency matrix for graph storage

        // Class Constructor
        public AdjacencyMatrix(int[,] array)
        {
            int size = array.GetLength(0);
            matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j && array[i, j] != 0)
                    {
                        throw new ArgumentException("Диагональные элементы должны иметь значение ноль");
                    }
                    else if (i != j && array[i, j] == 0)
                    {
                        matrix[i, j] = int.MaxValue;
                    }
                    else
                    {
                        matrix[i, j] = array[i, j];
                    }
                }
            }
        }

        // Determining the distance between the specified cities
        public int Get(int source, int destination)
        {
            return matrix[source, destination];
        }

        // Determining the order of the matrix
        public int GetSize()
        {
            return matrix.GetLength(0);
        }
    }
}
