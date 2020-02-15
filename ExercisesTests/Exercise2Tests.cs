using Exercises;
using System.Linq;
using Xunit;

namespace ExercisesTests
{
	public class Exercise2Tests
	{
		[Fact]
		public void FirstGivenExampleCase()
		{
			var A = new[] { 1, 3, 2, 1, };
			var B = new[] { 4, 2, 5, 3, 2, };

			var result = Exercise2.Solution(A, B);

			Assert.Equal(2, result);
		}

		[Fact]
		public void SecondGivenExampleCase()
		{
			var A = new[] { 2, 1, };
			var B = new[] { 3, 3, };

			var result = Exercise2.Solution(A, B);

			Assert.Equal(-1, result);
		}

		[Fact]
		public void LargeInputNegativeCase()
		{
			var A = Enumerable.Range(1, 100000).ToArray();
			var B = new[] { 0, };

			var result = Exercise2.Solution(A, B);

			Assert.Equal(-1, result);
		}

		[Fact]
		public void LargeInputPositiveCase()
		{
			var A = Enumerable.Range(1, 100000).ToArray();
			var B = new[] { 1, };

			var result = Exercise2.Solution(A, B);

			Assert.Equal(1, result);
		}
	}
}
