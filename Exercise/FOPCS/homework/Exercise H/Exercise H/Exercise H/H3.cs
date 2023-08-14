using System;
namespace HClass
{
	public class H3
	{
		public static string Substitute(string s, char c1, char c2)
		{
			string ans = "";
			for(int i = 0; i < s.Length; i++)
			{
				if (s[i] == c1)
				{
					ans += c2;
				}
				else
				{
					ans += s[i];
				}
			}
			return ans;
		}
	}
}

