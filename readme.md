# Mars Rover Kata Instructions

Develop an API that moves a rover around a planet. The planet is represented as a grid with *x* and *y* coordinates. The rover is also facing in a direction. The direction can be north (*N*), south (*S*), west (*W*) or east (*E*). The input received by the rover is a string representing the commands it needs to execute.

## 1. The Planet

The planet on which the rover moves is represented as a square grid, with size (x, y).

**Requirement**: Define a planet of size (x, y).

**Example**: (100,100) creates a planet of size 100 × 100.

## 2. Landing

When the rover lands on the planet, it begins its journey at the start of the grid facing north.

**Requirement**: When the rover lands on the planet its position shall be (0,0) facing north.

**Example**: An empty command (i.e., “”) to the rover returns its landing status (0,0,N).

## 3. Turning

The rover turns right or left. It remains in the same cell of the grid. Its direction changes accordingly.

**Requirement**: Compute the position of the rover after turning left (command “l”) or right (command “r”).

**Example**: A rover at position  (0,0,N) is at position (0,0,E) after executing command “r”. A rover at  position (0,0,N) is at position (0,0,W) after executing command “l”.

## 4. Moving

The rover moves forward or backward one grid cell in the direction that it is facing. The rover’s direction does not change.

**Requirement**: Compute the position of the rover after moving forward (command “f”) or backward (command “b”) one grid cell.

**Example**: A rover at position  (7,6,N) moves to (7,7,N) after executing a “f” command. A rover at  position (5,8,E) moves to (4,8,E) after executing a “b” command.

## 5. Moving and Turning Combined

The rover shall be able to execute arbitrary sequences of “f”, “b”, “l” and “r” commands.

**Requirement**: Compute the position of the rover after executing a series of commands.

**Example**: A rover at position (0,0,N) moves to position (2,2,E) after executing “ffrff”.

## 6. Wrapping

Since the planet is a sphere the rover wraps at the opposite edge once it moves over it.

**Requirement**: Compute the position of the rover moving over the edges. The rover shall spawn on the opposite side.

**Example**: A rover on a planet of  size 100 × 100, which moves backward (command “b”) after landing  (remember that landing always takes place at position (0,0,N)) moves to  position (0,99,N).

## 7. Positioning of Obstacles

Obstacles can be positioned on specific cells of the grid.

**Requirement**: Define the obstacles as a string (x1,y1) (*x*2,y2)… Place the obstacles on the grid.

**Example**: “(1,1) (4,5)” defines  two obstacles, one at position (1,1) and another at position (4,5).  Notice that the planet grid should be greater than or equal to 6 × 6.

## 8. Identifying a Single Obstacle

The rover might encounter (i.e., tries to move into) an obstacle. When it  does it should report the obstacle and continue executing the remaining  commands.

**Requirement**: Compute the  position of a rover encountering an obstacle and report the obstacle.  The same obstacle should be reported only once.

**Example**: A rover just landed  (position (0,0,N)). There is one obstacle at planet coordinates (2,2).  The rover executes “ffrfff” and reports (1,2,E) (2,2). Notice that the  same obstacle is encountered twice but reported only once.

## 9. Identifying Multiple Obstacles

The rover might encounter multiple obstacles. When it does, it should  report all of them once and in the order they were encountered.

**Requirement**: Compute the  position of the rover encountering obstacles, and report the obstacles  encountered in the order they are encountered. The same obstacle shall  be reported only once.

**Example**: A rover just landed  (position(0,0,N)). There are two obstacles at planet coordinates (2,2)  and (2,1). The rover executes “ffrfffrflf” and reports (1,1,E) (2,2)  (2,1). Notice that the first obstacle is encountered twice but reported  only once.

## 10. A Tour Around the Planet

The rover goes on a tour around the planet encountering several obstacles, and wrapping in both axes.

**Requirement**: Compute the  position of a rover that executes a series of commands that result in  moving along both axes in both directions, encountering several  obstacles and wrapping from both edges of the planet.

**Example**: The rover lands on a  6 × 6 planet with obstacles at (2,2), (0,5) and (5,0). It executes the  command “ffrfffrbbblllfrfrbbl” and returns (0,0,N) (2,2) (0,5) (5,0).

Congratulations, you are done!


# Template Used

Created with kata-bootstraps dotnet core 5 template: https://github.com/swkBerlin/kata-bootstraps/tree/master/csharp/dotnet-core5

## Initial Setup Used in Template

```sh
dotnet new classlib -n Kata
dotnet new xunit -n Kata.Tests
dotnet new sln
dotnet sln add Kata Kata.Tests
cd Kata.Tests
dotnet add reference ../Kata
dotnet add package FluentAssertions NSubstitute
cd ..
```

The following command should run all tests:

```sh
dotnet test
```
