using FluentAssertions;
using Xunit;

namespace MutationTesting.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _sut = new();

        [Theory]
        [InlineData(5, 5, 10)]
        public void Test_Add(int first, int second, int expected)
        {
            // Arrange and Act
            var result = _sut.Add(first, second);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        public void Test_Subtract(int first, int second, int expected)
        {
            // Arrange and Act
            var result = _sut.Subtract(first, second);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        public void Test_Multiply(int first, int second, int expected)
        {
            // Arrange and Act
            var result = _sut.Multiply(first, second);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        public void Test_Divide(int first, int second, int expected)
        {
            // Arrange and Act
            var result = _sut.Divide(first, second);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_DivideByZero()
        {
            // Arrange and Act
            var result = () => _sut.Divide(1, 0);

            // Assert
            result.Should().Throw<DivideByZeroException>();
        }
    }
}