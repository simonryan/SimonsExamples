namespace ArraysAndStrings
{
    public static class MatrixZeros
    {
        public static void ReplaceValues()
        {
             var matrix = new int[5,4] {
					                {1,2,3,4},
					                {0,2,3,4},
					                {4,5,6,0},
					                {5,7,6,7},
					                {4,6,0,1}
						            };

            var rowsWithZero = new int[matrix.GetLength(0)];
						
            // find all rows that have a 0
            for (var i=0; i < matrix.GetLength(0); i++)
            {
	            for(var j=0;j<matrix.GetLength(1);j++)
	            {
		            if (matrix[i,j] == 0)
		            {
			            rowsWithZero[i] = 1;
		            }
	            }
            }
            
            for (var x=0; x < rowsWithZero.Length; x++)
            {
	            if (rowsWithZero[x] == 1)
	            {
                    for (var y = 0; y < matrix.GetLength(1); y++ )
                    {
                        matrix[x, y] = 0;
                    }
	            }
            }
        }
    }
}
