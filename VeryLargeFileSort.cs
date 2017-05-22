// Imagine you have 20GB file with one string per line.
// Explain how you would sort the file

	// !- If strings are long. We can just read first letter of every string and sort them
	// !- We can take a pivot line, and sort using Quicksort. We need to know how many lines 
			// the file has to do the splitting. But at a time we just need in memory 3 lines
			// The ones we use to compare. Using the file as our memory