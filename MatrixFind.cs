// given a NxM matrix in which each row and column is sorted is sorted in ascending order, 
// write a method to find an element


// Noted:
	// - Methods could receive arrays instead of matrixes. That way we don't have to pass word in method

public Coordinate FindElement(int[][] matrix, int toFind)
{
	var row = FindRowWithElement(matrix, toFind, 0, matrix.GetLength(1)-1);
	if(matrix[row][0] == toFind)
		return new Coordinate{Row = row, Column = 0};

	var column = FindColumnWithElement(matrix, toFind, 0, matrix.GetLength(0)-1, row);
	var foundElement = column != -1;
	return new Coordinate
	{
		Row = (foundElement)? row : -1,
		Column = (foundElement)? column : -1,
	};
}


private int FindColumnWithElement(int[][] matrix, int toFind, int leftIndex, 
									int rightIndex, int row)
{
	if(leftIndex == rightIndex)
		return (matrix[row][leftIndex] == toFind)? leftIndex : -1;

	var middleColumn = (leftIndex + rightIndex)/2;
	if(matrix[row][middleColumn] < toFind)
		return FindColumnWithElement(matrix, toFind, middleColumn, rightIndex);

	return FindColumnWithElement(matrix, toFind, leftIndex, middleColumn);
}

private int FindRowWithElement(int[][] matrix, int toFind, int upperIndex, int lowerIndex)
{
	if(upperIndex == lowerIndex)
		return upperIndex;
	var middleRow = (upperIndex + lowerIndex)/2;
	if(matrix[0][middleRow] < toFind)
	{
		return FindRowWithElement(matrix, toFind, middleRow, lowerIndex);
	}
	else
	{
		return FindRowWithElement(matrix, toFind, upperIndex, middleIndex);
	}
}

public class Coordinate
{
	public int Row{get;set;}
	public int Column{get;set;}
}


/*
Find 49

1	2	3	7	9	10
12	16	18	20	21	22
23	24	25	28	30	31
38	39	45	48	49	52
80	87	89	99	100	101
120	125	128	149	153	159

Row Middle: 23 (index 2)
	49 > 23 -> Search rows 2, 3, 4, 5

========

(2)	23	24	25	28	30	31
(3)	38	39	45	48	49	52
(4)	80	87	89	99	100	101
(5)	120	125	128	149	153	159

Row Middle: 38 (3)
	49 > 28 -> Search rows 3, 4, 5

========

(3)	38	39	45	48	49	52
(4)	80	87	89	99	100	101
(5)	120	125	128	149	153	159

Row Middle: 80 (4)
	49 < 80	-> Search rows 3

========

Row 3 is one dimensional array? Yes -> Search Column

(3)	38	39	45	48	49	52

*/