using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RobotSimulator
{
    public Bearing Bearing { get; set; }
    public Coordinate Coordinate { get; set; }

    public RobotSimulator(Bearing bearing, Coordinate coordinate)
    {
        Bearing = bearing;
        Coordinate = coordinate;
    }    

    public void Advance()
    {
        switch (this.Bearing)
        {
            case Bearing.North:
                this.Coordinate.yCoord++;
                break;
            case Bearing.East:
                this.Coordinate.xCoord++;
                break;
            case Bearing.South:
                this.Coordinate.yCoord--;
                break;
            case Bearing.West:
                this.Coordinate.xCoord--;
                break;
            default:
                throw new NotSupportedException(String.Format("{0} is not a valid bearing.", this.Bearing));
        }
    }

    public void Advance(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Advance();
        }
    }

    public void TurnLeft()
    {
        switch (this.Bearing)
        {
            case Bearing.North:
                this.Bearing = Bearing.West;
                break;
            case Bearing.East:
                this.Bearing = Bearing.North;
                break;
            case Bearing.South:
                this.Bearing = Bearing.East;
                break;
            case Bearing.West:
                this.Bearing = Bearing.South;
                break;
            default:
                throw new NotSupportedException(String.Format("{0} is not a valid bearing.", this.Bearing));
        }
    }

    public void TurnRight()
    {
        switch (this.Bearing)
        {
            case Bearing.North:
                this.Bearing = Bearing.East;
                break;
            case Bearing.East:
                this.Bearing = Bearing.South;
                break;
            case Bearing.South:
                this.Bearing = Bearing.West;
                break;
            case Bearing.West:
                this.Bearing = Bearing.North;
                break;
            default:
                throw new NotSupportedException(String.Format("{0} is not a valid bearing.", this.Bearing));
        }
    }
    

    public void Simulate(string p)
    {
        foreach (char instruction in p)
        {
            switch (instruction)
            {
                case 'R':
                case 'r':
                    TurnRight();
                    break;
                case 'L':
                case 'l':
                    TurnLeft();
                    break;
                case 'A':
                case 'a':
                    Advance();
                    break;
                default:
                    throw new NotSupportedException(String.Format("{0} is not a valid instruction.", instruction));
            }
        }
    }
}

public class Coordinate
{
    public Coordinate(int x, int y)
    {
        this.xCoord = x;
        this.yCoord = y;
    }

    public override bool Equals(object obj)
    {
        Coordinate argument = obj as Coordinate;
        if (argument != null)
        {
            return xCoord == argument.xCoord && yCoord == argument.yCoord;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return String.Format("x: {0} y: {1}", xCoord, yCoord);
    }

    public int xCoord { get; set; }
    public int yCoord { get; set; }

}

public enum Bearing
{
    North,
    East,
    South,
    West
}

