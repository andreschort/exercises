using System;

namespace Exercises
{
	public static class Exercise3
	{
		public static int Solution(int N)
		{
			var n = 0;
			while (n < int.MaxValue)
			{
				if (N == SumDigits(n)) {
					return n;
				}

				n++;
			}

			throw new Exception("Reached int.MaxValue");
		}

		public static int SumDigits(int number)
		{
			var rest = number;
			var sum = 0;
			while (rest > 0)
			{
				sum += rest % 10;
				rest /=  10;
			}

			return sum;
		}
	}
}
