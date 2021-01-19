using FluentAssertions;
using System.Collections.Generic;
using System.Drawing;
using Xunit;

namespace Kata.Tests
{
    public class RoverTests
    {
        private readonly Rover _sut;

        public RoverTests()
        {
            var planet = new Planet(100, 100);
            _sut = new Rover();
            _sut.Land(planet);
        }

        [Fact]
        public void When_RoverLands_InNewPlanet_ShouldBeInDefaultCoordinates()
        {
            // Act
            var response = _sut.Command("");

            // Assert
            response.Should().Be(new Status(new Point(0,0), Orientation.North));
        }

        [Theory]
        [MemberData(nameof(RoverTurnsData))]
        public void When_RoverTurns_ShouldChangeDirection(string command, Status expectedStatus)
        {
            // Act
            var response = _sut.Command(command);

            // Assert
            response.Should().Be(expectedStatus);
        }

        public static IEnumerable<object[]> RoverTurnsData =>
            new List<object[]>
            {
                new object[] { "l", new Status(new Point(0,0), Orientation.West) },
                new object[] { "r", new Status(new Point(0,0), Orientation.East) }
            };
    }
}