using System;
namespace QueueOrStack
{
	public class CheckBalance
	{
		public CheckBalance()
		{
		}
		// a {b [c (d + e)/2 - f  ] + 1} + f
		public static bool Check(string s)
		{
			Stack<char> st1 = new Stack<char>();
			int n = s.Length;
			for (int i = 0; i < n; i++)
			{
				if (s[i] == '{' || s[i] == '}' || s[i] == '[' || s[i] == ']' || s[i] == '(' || s[i] == ')')
				{
					st1.Push(s[i]);
				}
			}
            // {[()]}
            Stack<char> st2 = new Stack<char>();
			while(st1.Count != 0)
			{
				char c = st1.Pop();
				if(c == '}' || c == ']' || c == ')')
				{
					st2.Push(c);
				}
				else
				{
					if(st2.Count > 0)
					{
						if(c == '(' && st2.Peek() == ')')
						{
                            st2.Pop();
                        }
                        else if(c == '{' && st2.Peek() == '}')
						{
                            st2.Pop();
                        }
                        else if(c == '[' && st2.Peek() == ']')
						{
                            st2.Pop();
						}
						else
						{
							return false;
						}
					}
					else
					{
						return false;
					}
				}
			}

			if (st2.Count > 0) return false;
			else return true;
        }
	}
}

