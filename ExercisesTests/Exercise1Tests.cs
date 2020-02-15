using Exercises;
using Xunit;

namespace ExercisesTests
{
	public class Exercise1Tests
	{
		[Fact]
		public void GivenExampleCase()
		{
			var input = new[] { 1, 4, -1, 3, 2 };

			var result = Exercise1.GetLinkedListLength(input);

			Assert.Equal(4, result);
		}

		[Fact]
		public void EndTokenAtIndex0()
		{
			var input = new[] { -1, 4, 1, 3, 2 };

			var result = Exercise1.GetLinkedListLength(input);

			Assert.Equal(1, result);
		}

		[Fact]
		public void EndTokenAtLastIndex()
		{
			var input = new[] { 1, 4, 3, 2, -1 };

			var result = Exercise1.GetLinkedListLength(input);

			Assert.Equal(3, result);
		}
	}
}
