using Shouldly;
using Xunit;

namespace Elevator.Library.Tests;

public class ElevatorButtonsTests
{
    private ElevatorButtons _target = new(0, 1000);

    [Fact]
    public void Test1()
    {
        var currentFloor = 10;
        var currentDirection = ElevatorButtons.Up;
        var buttonsPressed = new[]
        {
            7,
            15
        };

        var result = _target.NextStops(currentFloor, currentDirection, buttonsPressed);

        var expected = new[]
        {
            15,
            7,
        };

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Test2()
    {
        var currentFloor = 10;
        var currentDirection = ElevatorButtons.Down;
        var buttonsPressed = new[]
        {
            7,
            15
        };

        var result = _target.NextStops(currentFloor, currentDirection, buttonsPressed);
        
        var expected = new[]
        {
            7,
            15
        };

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Test3()
    {
        var currentFloor = 10;
        var currentDirection = ElevatorButtons.Down;
        var buttonsPressed = new[]
        {
            47,
            47,
            47,
            47,
            47
        };

        var result = _target.NextStops(currentFloor, currentDirection, buttonsPressed);

        var expected = new[]
        {
            47
        };
        
        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Test4()
    {
        var currentFloor = 500;
        var currentDirection = ElevatorButtons.Up;
        var buttonsPressed = new[]
        {
            420,
            570,
            140,
            230,
            915,
            820,
            499,
            820,
            177
        };

        var result = _target.NextStops(currentFloor, currentDirection, buttonsPressed);
        
        var expected = new[]
        {
            570,
            820,
            915,
            499,
            420,
            230,
            177,
            140
        };

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Test5()
    {
        var currentFloor = 1000;
        var currentDirection = ElevatorButtons.Down;
        var buttonsPressed = new[] { 0 };

        var result = _target.NextStops(currentFloor, currentDirection, buttonsPressed);

        var expected = new[] { 0 };
        
        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Test6()
    {
        var currentFloor = 600;
        var currentDirection = ElevatorButtons.Down;
        var buttonsPressed = new[]
        {
            420,
            570,
            140,
            230,
            915,
            820,
            499,
            820,
            177
        };

        var result = _target.NextStops(currentFloor, currentDirection, buttonsPressed);

        var expected = new[]
        {
            570,
            499,
            420,
            230,
            177,
            140,
            820,
            915
        };
        
        result.ShouldBeEquivalentTo(expected);
    }
}
