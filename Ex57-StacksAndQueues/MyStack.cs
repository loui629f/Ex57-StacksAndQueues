using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex57_StacksAndQueues
{
	public class MyStack<T>
	{
		List<T> stackList = new List<T>();
		public MyStack()
		{

		}

		public void Push(T item)
		{

			stackList.Add(item);

		}

		public T Pop()
		{

			T item = stackList[stackList.Count - 1];
			stackList.Remove(item);
			return item;

		}

		public T Peek()
		{

			return stackList[stackList.Count - 1];

		}

		public int Count()
		{

			return stackList.Count();

		}

		public Boolean IsEmpty()
		{

			if (stackList.Count < 1)
			{
				return true;
			}
			else
			{
				return false;
			}

		}


	}
}
