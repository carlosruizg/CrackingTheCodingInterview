//write a method to sort an array of strings so that all the anagrams are next to each other

// !- To find if two words are anagrams, we can count characters and if the count is the same
//		they are anagram


public void SortAnagram(string[] words)
{
	MergeSortAnagram(words, new string[words.Length], 0, words.Length -1);
}

private MergeSortAnagram(string[] words, string[] temp, int leftIndex, int rightIndex)
{
	if(words.Length > 0)
	{
		var middle = (leftIndex + rightIndex)/2;
		MergeSortAnagram(words, temp, leftIndex, middle);
		MergeSortAnagram(words, temp, middle+1, rightIndex);
		MergeAnagram(words, temp, leftIndex, middle, rightIndex);
	}
}

private MergeAnagram(string[] words, string[] temp, int leftIndex, int middleIndex, int rightIndex)
{
	var tempIndex = leftIndex;
	var leftStart = leftIndex;
	var leftEnd = middleIndex;
	var rightStart = rightIndex;
	var rightEnd = middleIndex + 1;
	while(leftStart <= leftEnd && rightStart <= rightEnd)
	{
		if(AreAnagram(words[leftStart], words[leftEnd]))
		{
			temp[tempIndex] = words[leftStart];
			temp[tempIndex+1] = words[leftEnd];
			tempIndex += 2;
			rightStart++;
		}
		else
		{
			temp[tempIndex] = words[leftStart];
			tempIndex++;
		}
		leftStart++;
	}

	// copy elements from left
	while(leftStart <= leftEnd)
	{
		temp[tempIndex] = words[leftStart];
		leftStart++;
	}

	// copy elements from right
	while(rightStart <= rightEnd)
	{
		temp[tempIndex] = words[rightStart];
		rightStart++;
	}
}

private bool AraAnagram(string word1, string word2)
{
	var occurences1 = new int[256]();
	var occurences2 = new int[256]();

	foreach(var c in word1.ToCharArray())
	{
		occurences1[(int)c]++;
	}

	foreach(var c in word2.ToCharArray())
	{
		occurences2[(int)c]++;
	}

	for(var i = 0; i < 256; i++)
	{
		if(occurences2[i] != occurences1[i])
			return false;
	}
	return true;
}