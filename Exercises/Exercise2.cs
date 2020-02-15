using System.Collections.Generic;

namespace Exercises
{
	public class Exercise2
	{
		public static int Solution(int[] A, int[] B)
		{
			var hash = new HashSet<int>();
			var match = int.MaxValue;

			foreach (var a in A)
			{
				hash.Add(a);
			}

			foreach (var b in B)
			{
				if (hash.Contains(b) && b < match)
				{
					match = b;
				}
			}

			if (match == int.MaxValue)
			{
				return -1;
			}

			return match;
		}
	}
}
