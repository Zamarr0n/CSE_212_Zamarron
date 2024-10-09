/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
using System.Diagnostics;
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // FILL IN CODE
        // you need to change the x and Y values to "Move"
        try{
            Debug.WriteLine($"Left: {_mazeMap}");
        }catch (InvalidOperationException){
            Debug.WriteLine("Invalid Operation Exception: Can't go that way!");
        }

    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        // FILL IN CODE
        try{
            Debug.WriteLine($"Rigth: {_mazeMap}");
        }catch (InvalidOperationException){
            Debug.WriteLine("Invalid Operation Exception: Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // FILL IN CODE
        // you need to change the x and Y values to "Move"
        try{
            foreach (var entry in _mazeMap)
        {
            var key = entry.Key;   // (int, int)
            var value = entry.Value; // bool[]
            Debug.WriteLine($"Key: ({key.Item1}, {key.Item2}), Values: [{string.Join(", ", value)}]");
        }
        }catch (System.InvalidOperationException){
            throw new InvalidOperationException("Can't go that way!");

        }

    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // FILL IN CODE
        try{
            Debug.WriteLine($"Down: {_mazeMap}");
        }catch (InvalidOperationException){
            Debug.WriteLine("Invalid Operation Exception: Can't go that way!");
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}