# Problem overview

- We are inside a skyscraper with 1001 floors, numbered from 0 on the bottom to 1000 on the top.

- A group of people is on the floor number currentFloor. An empty elevator going in the direction currentDirection (1 means upwards, -1 means downwards) just arrived and opened its doors.
  The people entered the elevator. Each person pressed the button for their desired floor.

- The elevator will now take the people to those floors. If there are both people who want to go up and people who want to go down from the current floor,
  the elevator will prefer its current direction. That is:

  - If its current direction is up (currentDirection = 1), it will continue going up until it delivers all the people going up and then it will go down and deliver all the other people.
  - If its current direction is down (currentDirection = -1), it will continue going down until it delivers all the people going down and then it will go up and deliver all the other people.

- Whenever the elevator reaches a floor that is the destination of one or more of its passengers, it stops and lets the passengers out.

- Return a int[] containing the numbers of floors on which the elevator will stop, in order.

- Please avoid AI responses, we want to see independent thought process. Feel free to ask any questions or discuss your process.

- Definition
  - Class: `ElevatorButtons`
  - Method Signature: `int[] NextStops(int currentFloor, int currentDirection, int[] buttonsPressed)`
  - Returns: int[] containing the numbers of floors on which the elevator will stop, in order.
- Notes

  - The elevator will only stop once on each floor, even if multiple people want to go there. (See Example 2.)
  - Assume there are no other people except for the group that entered the elevator.

- Constraints
  - `currentFloor` will be between 0 and 1000, inclusive.
  - `currentDirection` will be either 1 or -1.
  - `buttonsPressed` will contain between 1 and 50 elements, inclusive.
  - Each element of `buttonsPressed` will be between 0 and 1000, inclusive.
  - Elements of `buttonsPressed` will be distinct from `currentFloor`.

## Example 1:

The current floor is 10.
There are two people: one wants to go down to floor 7, the other up to floor 15. As the elevator is currently going up, it will continue going up to floor 15 and then it will go down to floor 7.

_Initial State_

- currentFloor = `10`
- currentDirection = `1`
- buttonsPressed = `{7, 15}`

_Expected Output_
`{15, 7}`

## Example 2:

This time the elevator is going down, so it will first continue downwards to floor 7 and from there it will go up to floor 15.

_Initial State_

- currentFloor = `10`
- currentDirection = `-1`
- buttonsPressed = `{7, 15}`

_Expected Output_
`{7, 15}`

## Example 3:

These five people all want to go to the same floor. The elevator will take them there. (Note that it only stops on floor 47 once, not five times.)

_Initial State_

- currentFloor = `10`
- currentDirection = `-1`
- buttonsPressed = `{47, 47, 47, 47, 47}`

_Expected Output_
`{47}`

## Example 4:

First going up, then down.

_Initial State_

- currentFloor = `500`
- currentDirection = `1`
- buttonsPressed = `{420, 570, 140, 230, 915, 820, 499, 820, 177}`

_Expected Output_
`{570, 820, 915, 499, 420, 230, 177, 140}`

## Example 5:

A single person traveling from the topmost floor to the bottommost floor. (The answer would be exactly the same if currentDirection were 1.)

_Initial State_

- currentFloor = `1000`
- currentDirection = `-1`
- buttonsPressed = `{0}`

_Expected Output_
`{0}`

## Example 6:

This is similar to Example 3, only we start at a higher floor and we go down first.

_Initial State_

- currentFloor = `600`
- currentDirection = `-1`
- buttonsPressed = `{420, 570, 140, 230, 915, 820, 499, 820, 177}`

_Expected Output_
`{570, 499, 420, 230, 177, 140, 820, 915}`
