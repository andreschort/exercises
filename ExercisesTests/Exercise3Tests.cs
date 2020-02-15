using Exercises;
using Xunit;

namespace ExercisesTests
{
	public class Exercise3Tests
	{
		[Fact]
		public void Solution_N_16()
		{
			var N = 16;

			var result = Exercise3.Solution(N);

			Assert.Equal(79, result);
		}

		[Fact]
		public void Solution_N_19()
		{
			var N = 19;

			var result = Exercise3.Solution(N);

			Assert.Equal(199, result);
		}

		[Fact]
		public void Solution_N_7()
		{
			var N = 7;

			var result = Exercise3.Solution(N);

			Assert.Equal(7, result);
		}

		[Fact]
		public void Solution_N_50()
		{
			var N = 50;

			var result = Exercise3.Solution(N);

			Assert.Equal(599999, result);
		}

		#region SumDigits

		[Fact]
		public void SumDigits_16()
		{
			var N = 16;

			var result = Exercise3.SumDigits(N);

			Assert.Equal(7, result);
		}

		[Fact]
		public void SumDigits_19()
		{
			var N = 19;

			var result = Exercise3.SumDigits(N);

			Assert.Equal(10, result);
		}

		[Fact]
		public void SumDigits_7()
		{
			var N = 7;

			var result = Exercise3.SumDigits(N);

			Assert.Equal(7, result);
		}

		[Fact]
		public void SumDigits_0()
		{
			var N = 0;

			var result = Exercise3.SumDigits(N);

			Assert.Equal(0, result);
		}

		[Fact]
		public void SumDigits_50()
		{
			var N = 50;

			var result = Exercise3.SumDigits(N);

			Assert.Equal(5, result);
		}

		[Fact]
		public void SumDigits_MaxInt()
		{
			var N = int.MaxValue;

			var result = Exercise3.SumDigits(N);

			Assert.Equal(46, result);
		}

		[Fact]
		public void SumDigits_Many9()
		{
			var N = 999999999;

			var result = Exercise3.SumDigits(N);

			Assert.Equal(81, result);
		}

		#endregion
	}
}
