using System;

namespace ListAndLinkedList
{
	public class Node
	{
		public string Val { get; set; }
		public Node Next { get; set; }

		public Node(string val, Node next)
		{
			this.Val = val;
			this.Next = next;
		}
	}

	public class MyList
	{
		// public
		public MyList()
		{
			// head表示一个空结点 指向第一个element
			head = new Node("head", null);
			tail = new Node("tail", null);
			head.Next = tail;
			tail.Next = head;
			numOfLinkedList = 0;
		}

		/// <summary>
		/// Adding a new element to the last of the linked list.
		/// </summary>
		/// <param name="newElement"></param>
		public void Add(string newElement)
		{
			Node newNode = new Node(newElement, null);
			if(Count() == 0)
			{
				head.Next = newNode;
				tail.Next = newNode;
			}
			else
			{
				tail.Next.Next = newNode;
				tail.Next = newNode;
			}
			this.numOfLinkedList++;
			/*
			Node newNode = new Node(newElement, null);
			Node last = GetAt(Count() - 1);
			this.numOfLinkedList++;
			last.Next = newNode;
			*/
        }

        /// <summary>
        /// Adding a new element to a specific position starting from 0.
        /// </summary>
        /// <param name="index">The position you wanna to add.</param>
        /// <param name="newElement">The new element you wanna to add.</param>
        /// <returns>If this operation is successful</returns>
        public bool Insert(int index, string newElement)
		{
			if (index < 0 || index > Count()) return false;

			Node newNode = new Node(newElement, null);

			// 如果插入在第一个 也就是index-1== -1 那么就返回head
			Node pre = GetAt(index - 1);
			Node cur = pre.Next;

			pre.Next = newNode;
			newNode.Next = cur;

			if(index == Count())
			{
				tail.Next = newNode;
			}

			this.numOfLinkedList++;
			return true;
		}

		/// <summary>
		/// 如果不成功 返回null
		/// </summary>
		/// 0 1 2 3 4 5
		/// <param name="index">The position you wanna to get.</param>
		/// <returns>The value with index of "index". If failed return null.</returns>
		public Node GetAt(int index)
		{
			// index = -1的时候 表示head
			if(index >= Count() || index < -1)
			{
				return null; // 不存在
			}

			// important
			if (index == -1) return head;

			Node temp=head;
			for(int i = 0; i <= index; i++)
			{
				// Console.WriteLine(temp.Val);
				temp = temp.Next;
			}
			return temp;
		}

		/// <summary>
		/// 如果删除成功 返回删除值
		/// 如果失败 返回null
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public string RemoveAt(int index)
		{
			if (index < 0 || index >= Count()) return null;
			
			Node pre = GetAt(index - 1);
			Node cur = GetAt(index);
			Node after = cur.Next;
			

			pre.Next = after;
			cur.Next = null;


			if (index == Count() - 1) tail.Next = pre;

			this.numOfLinkedList--;
			return cur.Val;
		}

		/// <summary>
		/// 返回当前链表元素个数
		/// </summary>
		/// <returns></returns>
		public int Count()
		{
			return numOfLinkedList;
		}

		/// <summary>
		/// 替换指定位置的值
		/// </summary>
		/// <param name="index"></param>
		/// <param name="newElement"></param>
		/// <returns></returns>
		public bool Replace(int index, string newElement)
		{
			if (index < 0 || index >= Count()) return false;
			GetAt(index).Val = newElement;
			return true;
		}


		/// <summary>
		/// Return if the linked list contains the element;
		/// </summary>
		/// <param name="element"></param>
		/// <returns></returns>
		public bool Contains(string element)
		{
			Node temp = head;
			for(int i = 0; i < Count(); i++)
			{
				temp = temp.Next;
				if(temp.Val == element)
				{
					return true;
				}
			}
			return false;
		}

        public override string ToString()
        {
			string output = "head";
			Node temp = head;
			for(int i = 0; i < Count(); i++)
			{
				temp = temp.Next;
				output = output + " -> " + temp.Val; 
			}
			return output;
        }
        // private

        /// <summary>
        /// head indicates the head of the Node linked list
        /// </summary>
        private Node head;

		/// <summary>
		/// I am trying to optimize the time effiency to O(1)
		/// </summary>
		private Node tail;

		/// <summary>
		/// The number of the linked list.
		/// </summary>
		private int numOfLinkedList;



	}
}

