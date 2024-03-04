using System.Collections;

namespace Lecture20
{
	internal class MyStack<T> : IEnumerable<T>
	{
		internal class MyNode
		{
			public T value;

			public MyNode? next = null;

			public MyNode(T value, MyNode? next = null)
			{
				this.value = value;
				this.next = next;
			}
		}

		private MyNode? first = null;

		public bool Empty => first == null;

		public T Peek => first.value;


		public bool Contains(T value)
		{
			MyNode? node = first;

			while (node != null) {
				if (ValueEquals(node.value, value)) {
					return true;
				}

				node = node.next;
			}

			return false;
		}


		public IEnumerator<T> GetEnumerator()
		{
			MyNode? node = first;

			while (node != null) {
				yield return node.value;
				node = node.next;
			}
		}


		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}


		public void Push(T value)
		{
			first = new MyNode(value, first);
		}


		public T Pop()
		{
			T value = first.value;
			first = first.next;
			return value;
		}


		public void Clear()
		{
			first = null;
		}


		private bool ValueEquals(T left, T right)
		{
			return left == null ?
				right == null :
				left.Equals(right);
		}
	}
}
