using System.Collections;

namespace Lecture19
{
	internal class MyLinkedList<T> : IEnumerable<T>
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

		private MyNode? last = null;

		public bool Empty => first == null;

		public T First => first.value;

		public T Last => last.value;


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


		public void AddFirst(T value)
		{
			first = new MyNode(value, first);
			last ??= first;
		}


		public void AddLast(T value)
		{
			MyNode node = new MyNode(value);

			if (last != null) {
				last.next = node;
			}

			last = node;
			first ??= node;
		}


		public void RemoveFirst()
		{
			first = first.next;

			if (first == null) {
				last = null;
			}
		}


		public void Clear()
		{
			first = null;
			last = null;
		}


		private bool ValueEquals(T left, T right)
		{
			return left == null ?
				right == null :
				left.Equals(right);
		}
	}
}
