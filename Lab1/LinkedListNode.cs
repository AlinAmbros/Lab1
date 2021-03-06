namespace Lab1
{
	public class LinkedListNode<T>
	{
		public T Value { get; set; }
		public LinkedListNode<T> Next { get; set; }

		public LinkedListNode(T value, LinkedListNode<T> next = null) 
		{
			Value = value;
			Next = next;
		}

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
