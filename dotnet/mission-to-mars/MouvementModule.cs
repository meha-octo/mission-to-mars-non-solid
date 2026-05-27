namespace mission_to_mars;

public static class MouvementModule
{
    
    public static Position Avancer(Position Position, Direction _direction)
    {
        return _direction switch
        {
            Direction.NORD => Position with { Y = Position.Y + 1 },
            Direction.SUD => Position with { Y = Position.Y - 1 },
            Direction.OUEST => Position with { X = Position.X - 1 },
            _ => Position with { X = Position.X + 1 },
        };
    }


    public static Position Reculer(Position Position, Direction _direction)
    {
         return _direction switch
        {
            Direction.NORD => Position with { Y = Position.Y - 1 },
            Direction.SUD => Position with { Y = Position.Y + 1 },
            Direction.OUEST => Position with { X = Position.X + 1 },
            _ => Position with { X = Position.X - 1 },
        };
    }
}