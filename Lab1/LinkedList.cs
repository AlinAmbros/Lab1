using System.Collections;
using System.Collections.Generic;

namespace Lab1
{
	class LinkedList<T> : IEnumerable<T>
	{
		private LinkedListNode<T> _head = null;
		private LinkedListNode<T> _tail = null;

		public void Prepand(T value)
		{
			var newNode = new LinkedListNode<T>(value, _head);
	
			_head = newNode;

			if(_tail == null)
			{
				_tail = newNode;
			}
		}

		public void Append(T value) 
		{
			var newNode = new LinkedListNode<T>(value);
			if (_head == null)
			{
				_head = newNode;
			}
			else
			{
				_tail.Next = newNode;
			}
			_tail = newNode;
		}

		public void Delete(T value)
		{
			if (_head == null) return;

			var current = _head;
			LinkedListNode<T> previous = null;

			while (current != null) 
			{
				if (current.Value.Equals(value)) 
				{
					if (previous != null)
					{
						previous.Next = current.Next;
						if (current.Next == null)
						{
							_tail = previous;
						}
					}
					else 
					{
						_head = _head.Next;
						if (_head == null)
						{
							_tail = null;
						}
						break;
					}
				}
				previous = current;
				current = current.Next;
			}
		}

		public LinkedListNode<T> Find(T value)
		{
			if (_head == null) return null;

			var currentNode = _head;

			while (currentNode != null)
			{
				if (value != null && currentNode.Value.Equals(value)) 
				{
					return currentNode;
				}
				currentNode = currentNode.Next;
			}
			return null;
		}

		public LinkedListNode<T> DeleteTail() 
		{
			if (_tail == null) return null;
			LinkedListNode<T> deletedTail = _tail;

			if (_head == _tail) 
			{
				_head = null;
				_tail = null;
				return deletedTail;
			}

			var currentNode = _head;
			while (currentNode.Next != null)
			{
				if (currentNode.Next.Next == null)
				{
					currentNode.Next = null;
				}
				else
				{
					currentNode = currentNode.Next;
				}
			}
			_tail = currentNode;
			return deletedTail;

		}

		public LinkedListNode<T> DeleteHead()
		{
			if (_head == null) return null;
			LinkedListNode<T> deletedHead = _head;

			if (_head.Next != null)
			{
				_head = _head.Next;
			}
			else 
			{
				_head = null;
				_tail = null;
			}
			
			return deletedHead;

		}

		public LinkedList<T> FromArray(T[] values) 
		{
			foreach (var value in values) 
			{
				Append(value);
			}
			return this;
		}
		
		public LinkedListNode<T>[] ToArray() 
		{
			var nodes = new List<LinkedListNode<T>>();
			var currentNode = _head;

			while (currentNode != null) 
			{
				nodes.Add(currentNode);
				currentNode = currentNode.Next;
			}
			return nodes.ToArray();
		}

		public void Reverse() 
		{
			var currNode = _head;
			LinkedListNode<T> prevNode = null;
			LinkedListNode<T> nextNode = null;

			while (currNode != null) 
			{
				nextNode = currNode.Next;
				currNode.Next = prevNode;
				prevNode = currNode;
				currNode = nextNode;
			}
			_tail = _head;
			_head = prevNode;
		}

		public override string ToString()
		{
			return _head.ToString();
		}

		public IEnumerator<T> GetEnumerator()
		{
			var current = _head;
			while (current != null)
			{
				yield return current.Value;
				current = current.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this).GetEnumerator();
		}
	}
}
