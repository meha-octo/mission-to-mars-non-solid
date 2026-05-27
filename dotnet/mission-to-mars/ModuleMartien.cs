namespace mission_to_mars;

public abstract class ModuleMartien(Direction direction, Position position) : IModuleMartien
{
    public bool IsPretPourRecuperation { get; protected set; }

    public Position Position { get; protected set; } = position;

    public void Avancer()
    {
        Position = direction switch
        {
            Direction.NORD => Position with { Y = Position.Y + 1 },
            Direction.SUD => Position with { Y = Position.Y - 1 },
            Direction.OUEST => Position with { X = Position.X - 1 },
            Direction.Nord_Ouest => Position with { Y = Position.Y + 1, X = Position.X - 1 },
            _ => Position with { X = Position.X + 1 },
        };
    }

    public void Reculer()
    {
        Position = direction switch
        {
            Direction.NORD => Position with { Y = Position.Y - 1 },
            Direction.SUD => Position with { Y = Position.Y + 1 },
            Direction.OUEST => Position with { X = Position.X + 1 },
            Direction.Nord_Ouest => Position with { Y = Position.Y - 1, X = Position.X + 1 },
            _ => Position with { X = Position.X - 1 },
        };
    }

    public abstract void PreparerRécupération();

    public abstract void ActiverRecuperation();
}
