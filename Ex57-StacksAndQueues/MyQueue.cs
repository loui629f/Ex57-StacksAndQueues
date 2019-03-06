using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex57_StacksAndQueues
{
	public class MyQueue<T>
	{

		List<T> queueList = new List<T>();

		public MyQueue()
		{



		}

		public void Enqueue(T item)
		{

			queueList.Add(item);

		}

		public T Dequeue()
		{			

			if (IsEmpty())
			{
				return default(T);
			}
			else
			{
				T item = queueList[0];
				queueList.RemoveAt(0);
				// queueList.Remove(item);
				return item;
			}			

		}

		public int Count()
		{
			return queueList.Count;
		}

		public Boolean IsEmpty()
		{

			if (queueList.Count < 1)
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
