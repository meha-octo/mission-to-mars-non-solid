namespace mission_to_mars;

public abstract class MouvementModule(Position Position, Direction Direction)
{
    public Position Position { get; protected set; } = Position;

    public void Avancer()
    {
        Position = Direction switch
        {
            Direction.NORD => Position with { Y = Position.Y + 1 },
            Direction.SUD => Position with { Y = Position.Y - 1 },
            Direction.OUEST => Position with { X = Position.X - 1 },
            _ => Position with { X = Position.X + 1 },
        };
    }


    public void Reculer()
    {
         Position = Direction switch
        {
            Direction.NORD => Position with { Y = Position.Y - 1 },
            Direction.SUD => Position with { Y = Position.Y + 1 },
            Direction.OUEST => Position with { X = Position.X + 1 },
            _ => Position with { X = Position.X - 1 },
        };
    }
}