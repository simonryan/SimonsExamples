namespace ArraysAndStrings
{
    public static class RotateMatrix
    {
        public static void RotateSquareMatrix()
        {
            var array = new int[4,4] {
                { 1,2,3,4 },
                { 5,6,7,8 },
                { 9,10,11,12 },
                { 13,14,15,6 }
            };

            int[,] rotated = RotateIt(array, 4);


        }

        static int[,] RotateIt(int[,] matrix, int n)
        {
            var ret = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ret[i, j] = matrix[n - j - 1, i];
                }
            }

            return ret;
        }

        public static char[,] RotateRectangularMatrix()
        {
            var matrix = new char[4,3] // rows / cols
                {
                    {'a', 'b', 'c'},
                    {'d', 'e', 'f'},
                    {'g', 'h', 'i'},
                    {'j', 'k', 'l'}
                };
            

            var transposedMatrix = new char[matrix.GetLength(1),matrix.GetLength(0)];
            var reversedMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];

            // transpose all elements
            for (var i = 0; i < matrix.GetLength(0); ++i)
            {
                for (var j = 0; j < matrix.GetLength(1); ++j)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }

            // reverse each line
            for (var x = 0; x < transposedMatrix.GetLength(0); x++ )
            {
                for (var y = 0; y < transposedMatrix.GetLength(1); y++)
                {
                    reversedMatrix[x, y] = transposedMatrix[x, transposedMatrix.GetLength(1) - y - 1];
                }
            }

            return reversedMatrix;
        }

    }
}
