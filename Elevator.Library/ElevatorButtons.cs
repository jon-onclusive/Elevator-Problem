using System;
using System.Collections.Generic;
using System.Linq;


namespace Elevator.Library;

public class ElevatorButtons
{
    public const int Up = 1;
    public const int Down = -1;

    public ElevatorButtons(int v1, int v2)
    {
    }

    public int[] NextStops(int currentFloor, int currentDirection, int[] buttonsPressed)
    {
        try
        {
            if (buttonsPressed == null || buttonsPressed.Length == 0)
                return Array.Empty<int>();
                
            //if buttonsPressed contains only one floor => return this floor
            var stopsDistinct = buttonsPressed.Distinct().ToList();
            if (stopsDistinct.Count == 1)
                return new[] { stopsDistinct[0] };
            
            //order stops based on currentDirection
            List<int> firstStops;
            List<int> secondStops;

            if (currentDirection == Up)
            {
                firstStops = stopsDistinct.Where(f => f > currentFloor).OrderBy(f => f).ToList();
                secondStops = stopsDistinct.Where(f => f < currentFloor).OrderByDescending(f => f).ToList();
            }
            else
            {
                firstStops = stopsDistinct.Where(f => f < currentFloor).OrderByDescending(f => f).ToList();
                secondStops = stopsDistinct.Where(f => f > currentFloor).OrderBy(f => f).ToList();
            }
            return firstStops.Concat(secondStops).ToArray();
            
        }
        catch (Exception e)
        {
            Console.WriteLine("Error in NextStops :" + e.Message);
            return Array.Empty<int>();

        }
    }
}