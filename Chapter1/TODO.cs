

// 1.6 Rotate NxN image 90 degrees
void Rotate(int [,] img)
{
	var n = img.GetLength(0);
	var rotatedImg = new int[n,n];
	for(var i = 0, var j = n-1; i < n; i++, j--)
	{
		for(var k = 0; k < n; k++)
		{
			rotatedImg[k,j] = img[k,i];
		}
	}
	return rotatedImg;
}

// 1.7 if element is 0, row and column is all clear with zeroes
void Clear(int [,] matrix)
{
	var emptyRows = new bool[matrix.GetLength(0)];
	var emptyCols = new bool[matrix.GetLength(1)];

	for(var i = 0; i < matrix.GetLength(0); i++)
	{
		for(var j = 0; j < matrix.GetLength(1); j++)
		{
			if(emptyCols[j])
				continue;
			if(matrix[i,j] == 0)
			{
				emptyCols[j] = true;
				emptyRows[i] = true;
			}
		}
	}

	for(var i = 0; i < matrix.GetLength(0); i++)
	{
		for(var j = 0; j < matrix.GetLength(1); j++)
		{
			if(emptyRows[i] || emptyCols[j])
				matrix[i,j] = 0;
		}
	}

	return matrix;
}

// 1.8 IsRotation
bool IsRotation(string s1, string s2)
{
	if(s1.Length != s2.Length)
		return false;
	var s1Aux = s1 + s1;
	return IsSubstring(s2, s1Aux);
}

