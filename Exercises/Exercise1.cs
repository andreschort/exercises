namespace Exercises
{
	public class Exercise1
	{
		public static int GetLinkedListLength(int[] A)
		{
			var i = 0;
			var length = 1;
			while (i < A.Length && A[i] != -1)
			{
				i = A[i];
				length++;
			}

			return length;
		}
	}
}
