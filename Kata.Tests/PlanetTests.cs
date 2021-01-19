using FluentAssertions;
using Xunit;

namespace Kata.Tests
{

    public class PlanetTests
    {
        [Fact]
        public void Planet_ShouldBeCreatedWithDimensions()
        {
            var sut = new Planet(100, 100);

            sut.Width.Should().Be(100);
            sut.Height.Should().Be(100);
        }
    }
}