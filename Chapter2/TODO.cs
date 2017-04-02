
// 2
	// Implement double linkedlist.

// 2.1 Remove duplicates from unsorted linked list
void RemoveDuplicated(Node head)
{
	if(head == null)
		return;
	var hashT = new HashSet();
	while(node.Next != null)
	{
		if(hashT.ContainsKey(node.Next.Value))
		{
			node.Next = node.Next.Next;
		}
		else
		{
			hashT.Add(node.Next.Value);
		}
	}
	return;
}



void RemoveDuplicatesWithoutExtraStructure(Node head)
{
	if(head == null)
		return;
	var current = head;
	while(current != null)
	{
		var runner = current.Next;
		var prev = current;
		while(runner != null)
		{
			if(current.Value == runner.Value)
				prev.Next = current.Next;
			else
				prev = runner;
			runner = runner.Next;
		}
		current = current.Next;
	}
	return;
}


// 2.2 Find the Kth Value
Node FindKthValue(Node head, int k)
{
	if(head == null)
		return null;
	var runner = head;
	for(var i = 0; i < k; i++)
	{
		if(runner == null)
			return null;
		runner = runner.Next;
	}
	var current = head;
	while(runner.Next != null)
	{
		runner = runner.Next;
		current = current.Next;
	}
	return current;
}

// 2.3 Delete node with just the node given
void Delete(ref Node middleNode)
{
	middleNode = middleNode.Next;
	return;
}

// 2.4 Partition
Node Partition(Node head, int x)
{
	if(head == null)
		return null;
	Node smaller; 
	Node greater;
	Node smallerHead;
	Node greaterHead;
	while(head != null)
	{
		if(head.Value < x)
		{
			if(smaller == null)
			{
				smaller = new Node(head.Value);
				smallerHead = smaller;
			}
			else
			{
				smaller.Next = new Node(head.Value);
				smaller = smaller.Next;
			}
		}
		else
		{
			if(greater == null)
			{
				greater = new Node(head.Value);
				greaterHead = greater;
			}
			else
			{
				greater.Next = new Node(head.Value);
				greater = greater.Next;
			}
		}
	}
	if(smallerHead == null)
		return greaterHead;
	smaller.Next = greaterHead;
	return smallerHead;
}


// 2.5 Sum Linked Lists
Node SumLinkedLists(Node n1, Node n2)
{
	var reminder = 0;
	Node nResult;
	Node nHead;
	while(n1 != null && n2 != null)
	{
		var tempValue = reminder;
		if(n1 != null)
		{
			tempValue += n1.Value;
			n1 = n1.Next;
		}

		if(n2 != null)
		{
			tempValue += n2.Value;
			n2 = n2.Next;
		}

		var newValue = tempValue % 10;
		reminder = tempValue / 10;

		if(nResult != null)
		{
			nResult = new Node(newValue);
			nHead = nResult;
		}
		else
		{
			nResult.Next = new Node(value);
			nResult = nResult.Next;
		}
	}

	//Add extra nodes
	while(reminder > 0)
	{
		var val = reminder % 10;
		nResult.Next = new Node(val);
		nResult = nResult.Next;
		reminer /= 10;
	}

	return nHead;
}

// TODO digits forward

// 2.6 Get Loop
Node GetLoopNode(Node head)
{
	if(head == null)
		return null;
	var hashT = new HashSet();
	while(head != null)
	{
		if(hashT.ContainsKey(head))
			return head;
		hashT.Add(head);
		head = head.Next;
	}
	return null;
}